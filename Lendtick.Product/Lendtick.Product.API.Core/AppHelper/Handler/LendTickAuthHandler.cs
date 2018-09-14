using Lendtick.Product.API.Core.AppHelper.Scheme;
using Lendtick.Product.API.Core.Model.Response;
using Lendtick.Product.Common;
using Lendtick.Product.Common.Resources;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Lendtick.Product.API.Core.AppHelper.Handler
{
    public class LendTickAuthHandler : AuthenticationHandler<LendTickAuthSchemeOptions>
    {
        private readonly HttpClient client;

        public LendTickAuthHandler(IOptionsMonitor<LendTickAuthSchemeOptions> options, UrlEncoder encoder,
                                   ILoggerFactory logger, ISystemClock clock, HttpClient httpClient)
            : base(options, logger, encoder, clock)
        {
            client = httpClient;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            StringValues authorization;
            AuthCheckResponse response = new AuthCheckResponse();

            // Check if incoming request contains Authorization header key
            if (!Request.Headers.TryGetValue(HeaderNames.Authorization, out authorization))
            {
                return AuthenticateResult.Fail(Message.ERROR_REQUEST_AUTH_NOT_FOUND);
            }

            // Check if Authorization header has value
            if (authorization.Count <= 0 ||
                authorization.Any(x => string.IsNullOrWhiteSpace(x)))
            {
                return AuthenticateResult.Fail(Message.ERROR_REQUEST_AUTH_TOKEN_EMPTY);
            }

            string token = authorization[0].Replace(AppConst.BEARER_AUTH_TYPE, string.Empty).Trim();

            this.client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(AppConst.BEARER_AUTH_TYPE, token);

            using (HttpResponseMessage message = await client.GetAsync(AppConst.LENDTICK_AUTH_CHECK_URI))
            {
                if (!message.IsSuccessStatusCode)
                {
                    return AuthenticateResult.Fail(Message.ERROR_REQUEST_AUTH_UNAUTHORIZED);
                }

                var value = await message.Content.ReadAsStringAsync();
                response = JsonConvert.DeserializeObject<AuthCheckResponse>(value);
            }

            // Create authenticated user
            List<Claim> claims = new List<Claim>
            {
                new Claim(AppConst.CLAIM_TYPE_USER_ID, response.Data.id_user.ToString(),
                          ClaimValueTypes.Integer64, AppConst.LENDTICK_AUTH_URI)
            };

            var identities = new List<ClaimsIdentity> { new ClaimsIdentity(claims, AppConst.CLAIM_TYPE_USER_ID) };
            var ticket = new AuthenticationTicket(new ClaimsPrincipal(identities),
                                                  AppConst.LENDTICK_JWT_AUTH_SCHEME_OPTIONS);

            return AuthenticateResult.Success(ticket);
        }
    }
}
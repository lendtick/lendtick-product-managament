using Lendtick.Product.API.Core.AppHelper.Handler;
using Lendtick.Product.API.Core.AppHelper.Scheme;
using Lendtick.Product.Common;
using Microsoft.AspNetCore.Authentication;
using System;

namespace Lendtick.Product.API.Core.AppHelper.Extension
{
    public static class LendTickAuthBuilderExtension
    {
        public static AuthenticationBuilder AddLentickJWTAuth(this AuthenticationBuilder builder, Action<LendTickAuthSchemeOptions> configureOptions)
        {
            return builder.AddScheme<LendTickAuthSchemeOptions, LendTickAuthHandler>(AppConst.LENDTICK_JWT_AUTH_SCHEME_OPTIONS, configureOptions);
        }
    }
}
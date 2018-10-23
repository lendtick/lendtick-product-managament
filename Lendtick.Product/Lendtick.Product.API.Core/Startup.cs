using Lendtick.Product.API.Core.AppHelper.Extension;
using Lendtick.Product.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;

namespace Lendtick.Product.API.Core
{
    /// <summary>
    /// </summary>
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder => builder.AllowAnyOrigin()
                                      .AllowAnyMethod()
                                      .AllowAnyHeader());
            });
            services.Configure<MvcOptions>(option => {
                option.Filters.Add(new CorsAuthorizationFilterFactory("AllowAll"));
            });
            services.AddMvc(options =>
            {
                options.Filters.Add(new AuthorizeFilter(new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build()));
            })
            .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
            .AddJsonOptions(c =>
            {
                c.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("dev", new Info
                {
                    Title = "Lendtick Product API Core",
                    Version = "Dev"
                });

                c.AddSecurityDefinition(AppConst.BEARER_AUTH_TYPE,
                    new ApiKeyScheme
                    {
                        In = "Header",
                        Description = "JWT Token issued by Lendtick User Management API",
                        Name = "Authorization"
                    });

                c.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>>
                {
                    { AppConst.BEARER_AUTH_TYPE, Enumerable.Empty<string>() }
                });

                string xmlDocFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                string xmlDocPath = Path.Combine(AppContext.BaseDirectory, xmlDocFile);

                c.IncludeXmlComments(xmlDocPath);
            });

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = AppConst.LENDTICK_JWT_AUTH_SCHEME_OPTIONS;
                options.DefaultChallengeScheme = AppConst.LENDTICK_JWT_AUTH_SCHEME_OPTIONS;
            }).AddLentickJWTAuth(o => { });

            services.AddSingleton(new HttpClient() { BaseAddress = new Uri(AppConst.LENDTICK_AUTH_CHECK_URI) });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/dev/swagger.json", "Lendtick.Product.API.Core");
                c.RoutePrefix = "swagger";
            });

            app.UseCors("AllowAll");
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}

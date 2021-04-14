#region using

using System;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NetAppCommon.Extensions.DependencyInjection;
using NetAppCommon.Helpers;
using NetAppCommon.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PortalApiGus.ApiRegon.DataBase.Data;
using PortalApiGus.ApiRegon.DataBase.Models;

#endregion

namespace PortalApiGus.ApiRegon.WebApi
{
    public class Startup
    {
        #region private readonly log4net.ILog _log4Net

        // <summary>
        // Referencja klasy Log4NetLogger
        // Reference to the Log4NetLogger class
        // </summary>
        private readonly ILog _log4Net =
            Log4NetLogger.GetLog4NetInstance(MethodBase.GetCurrentMethod()?.DeclaringType);

        #endregion

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //#region CommonDistributedMemoryCache

            ////services.AddDistributedMemoryCache();
            //services.AddNetAppCommonDistributedMemoryCache();

            //#endregion

            #region Kontekst bazy danych PortalApiGus.ApiRegon.DataBase

            try
            {
                // Kontekst bazy danych PortalApiGus.ApiRegon.DataBase
                var portalApiGusApiRegonDataAppSettings = AppSettings.GetInstance();
                services.AddDbContextPool<DataBaseContext>(options => options.UseSqlServer(
                    portalApiGusApiRegonDataAppSettings.GetConnectionString(),
                    element => element.EnableRetryOnFailure()
                        .MigrationsHistoryTable("__EFMigrationsHistory", "pagard")));
            }
            catch (Exception e)
            {
                _log4Net.Error($"\n{e.GetType()}\n{e.InnerException?.GetType()}\n{e.Message}\n{e.StackTrace}\n", e);
            }

            #endregion

            #region Konfiguracja autoryzacja

            services.AddAuthentication().AddCookie(
                    options =>
                    {
                        options.AccessDeniedPath = "/Authentication/AccessDenied";
                        options.Cookie.Name = Assembly.GetExecutingAssembly().GetName().Name;
                        options.Cookie.HttpOnly = true;
                        options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                        options.LoginPath = "/Authentication";
                        options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                        options.SlidingExpiration = true;
                    }
                )
                .AddJwtBearer("Bearer", CookieAuthenticationDefaults.AuthenticationScheme, options =>
                {
                    options.SaveToken = true;
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        LifetimeValidator = (before, expires, token, param) => expires > DateTime.UtcNow,
                        //ClockSkew = TimeSpan.FromMinutes(5),
                        RequireSignedTokens = true,
                        RequireExpirationTime = true,
                        //ValidateIssuer = true,
                        ValidateIssuer = false,
                        //ValidateAudience = true,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        //ValidIssuer = Configuration["TokenProviderOptions:Issuer"],
                        //ValidAudience = Configuration["TokenProviderOptions:Issuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(EncryptDecrypt.EncryptDecrypt.GetRsaFileContent("id_rsa.ppk.pub")))
                    };
                    options.Events = new JwtBearerEvents
                    {
                        OnMessageReceived = context =>
                        {
                            if (context != null && context.Request.Query.ContainsKey("AccessToken"))
                            {
                                context.Token = context.Request.Query["AccessToken"];
                            }

                            return Task.CompletedTask;
                        }
                    };
                });

            services.AddAuthentication(HttpSysDefaults.AuthenticationScheme);
            services.AddAuthentication(NegotiateDefaults.AuthenticationScheme).AddNegotiate();
            services.AddAuthorization();

            #endregion

            #region AddControllers

            services.AddControllers().AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver
                    {
                        NamingStrategy = new CamelCaseNamingStrategy()
                    };
                    options.SerializerSettings.Formatting = Formatting.Indented;
                }
            );

            #endregion

            #region Kestrel

            // Ważne Konfiguracja Kestrel !!!
            services.Configure<KestrelServerOptions>(Configuration.GetSection("Kestrel"));

            #endregion

            #region Swagger

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "PortalApiGus.ApiRegon.WebApi", Version = "v1"});
            });

            services.AddSwaggerGenNewtonsoftSupport();

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            #region CultureInfo

            CultureInfo[] supportedCultures = { new("pl-PL") };
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("pl-PL"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });

            #endregion

            //if (env.IsDevelopment())
            //{
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PortalApiGus.ApiRegon.WebApi v1"));
            //}
            //app.UseHttpsRedirection();
            app.UseRouting();
            var cookiePolicyOptions = new CookiePolicyOptions { MinimumSameSitePolicy = SameSiteMode.Strict };
            app.UseCookiePolicy(cookiePolicyOptions);
            app.UseAuthorization();
            app.UseAuthentication();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    "default",
                    "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    "areas",
                    "{area}/{controller}/{action}/{id?}");
                endpoints.MapControllers();
            });

            #region Migracja bazy danych PortalApiGus.ApiRegon.DataBase

            Task.Run(() =>
            {
                try
                {
                    // Migracja bazy danych PortalApiGusApiRegonData.Data.PortalApiGusApiRegonDataDbContext
                    EntityContextHelper.RunMigrationAsync<DataBaseContext>(app.ApplicationServices)
                        .Wait();
                }
                catch (Exception e)
                {
                    _log4Net.Error($"\n{e.GetType()}\n{e.InnerException?.GetType()}\n{e.Message}\n{e.StackTrace}\n", e);
                }
            }).Wait();

            #endregion
        }
    }
}

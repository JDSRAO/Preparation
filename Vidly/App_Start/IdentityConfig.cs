using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Vidly.Identity;
using Vidly.Providers;

namespace Vidly.App_Start
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app)
        {
            /* OAuth based authentication */
            //var OAuthBearerOptions = new OAuthBearerAuthenticationOptions()
            //{
            //    Provider = new QueryStringOAuthBearerProvider()
            //};
            //var accessTokenLifeTime = Convert.ToInt32(WebConfigurationManager.AppSettings["access.token.lifetime"]);

            //var OAuthServerOptions = new OAuthAuthorizationServerOptions()
            //{
            //    //For Dev enviroment only (on production should be AllowInsecureHttp = false)
            //    AllowInsecureHttp = true,
            //    TokenEndpointPath = new PathString("/token"),
            //    AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(accessTokenLifeTime),
            //    //Provider = new SimpleAuthorizationServerProvider(),
            //    //RefreshTokenProvider = new SimpleRefreshTokenProvider()
            //};

            //// Token Generation
            //app.UseOAuthAuthorizationServer(OAuthServerOptions);

            ////Token Consumption
            //app.UseOAuthBearerAuthentication(OAuthBearerOptions);

            /* Cookie based Authtneication */
            app.CreatePerOwinContext(() => new AuthContext());
            //app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);
            //app.CreatePerOwinContext<RoleManager<AppRole>>((options, context) =>
            //    new RoleManager<AppRole>(
            //        new RoleStore<AppRole>(context.Get<MyDbContext>())));
            var cookieOptions = new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Home/Login"),
            };

            app.UseCookieAuthentication(cookieOptions);
        }
    }
}
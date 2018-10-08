using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using Vidly.Filters;

namespace Vidly
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config = ConfigureWebApi();
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        /// <summary>
        /// Configures the WebAPI
        /// </summary>
        /// <returns>HttpConfiguration Object populated with default configuration values</returns>
        private static HttpConfiguration ConfigureWebApi()
        {
            //Configuration objetct
            HttpConfiguration config = new HttpConfiguration();

            //Error detail policy
            config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;

            config.Filters.Add(new HandleExceptionAttribute());
            //Map routes
            config.MapHttpAttributeRoutes();

            //Formatter for json
            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            //Added for Entity Frameowrk Reference Loop issues
            jsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            return config;
        }
    }
}

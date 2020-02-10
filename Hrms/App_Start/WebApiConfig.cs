using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Configuration;
using Hrms.Filters;
using System.Net.Http.Formatting;
using Newtonsoft.Json.Serialization;

namespace Hrms
{
    public static class WebApiConfig
    {
        private static string URL = "http://localhost:4200";

        public static void Register(HttpConfiguration config)
        {
            URL = ConfigurationManager.AppSettings["AllowUrl"];
            // Web API configuration and services
            var cors = new EnableCorsAttribute(URL, "*", "*");
            config.EnableCors(cors);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Filters.Add(new ApiAuthenticationFilter());

            var jsonFormatter = new JsonMediaTypeFormatter
            {
                SerializerSettings = { ContractResolver = new CamelCasePropertyNamesContractResolver() }
            };

            config.Formatters.Clear();
            config.Formatters.Add(jsonFormatter);
        }
    }
}

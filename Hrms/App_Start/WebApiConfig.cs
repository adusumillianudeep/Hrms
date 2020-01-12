using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Configuration;

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
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace QHRO_WEB
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Solicitar Cirugia Paciente",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Quirofanos", action = "Solicitar", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Estado de quirofanos",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Quirofanos", action = "Estado", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Programaciones",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Quirofanos", action = "Programaciones", id = UrlParameter.Optional }
            );
        }
    }
}

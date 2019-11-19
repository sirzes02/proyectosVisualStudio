using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace quiz1_2019_2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Buscar",
                url: "Buscar/{nombrePelicula}",
                defaults: new { controller = "Peliculas", action = "Buscar", nombrePelicula = "" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Peliculas", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

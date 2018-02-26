using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lektion_0129_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "DatorRule",
                url: "Dator",
                defaults: new { controller = "ViewModelEx", action = "Main", id = UrlParameter.Optional }
            );

            routes.MapRoute(
              name: "CarsToBilar",
              url: "Bilar/{action}",
              defaults: new { controller = "Cars", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Test",
                url: "Om",
                defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Mattetabel",
                url: "Mattetabel",
                defaults: new { controller = "Home", action = "Mattetabel", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "HomeToHem",
                url: "Hem/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }// detta är för url rader webbaddres localhostraden, detta kalas mapruts ruterna på kartan.
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}

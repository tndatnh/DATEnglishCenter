using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DATEnglishCenter
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
     name: "DATRoute",
     url: "DAT/{action}/{id}",
     defaults: new { controller = "DAT", action = "Index", id = UrlParameter.Optional }
 );

        }
    }
}

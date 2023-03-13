using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Fresh1ErpProj
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
                name:"twoid",
                url: "api/{controller}/{action}/{courseid}/{feemodeid}",
                new {  courseid =UrlParameter.Optional,
                       feemodeid = UrlParameter.Optional
                });
        }
    }
}

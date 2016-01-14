using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
            new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            new { controller = "^H.*", action = "^Index$|^About$", httpMethod = new HttpMethodConstraint("GET"), id = new RangeRouteConstraint(10, 20) },
            new[] { "URLsAndRoutes.Controllers" });
        }
    }
}

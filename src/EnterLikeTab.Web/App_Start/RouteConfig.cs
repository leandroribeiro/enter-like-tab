using System.Web.Mvc;
using System.Web.Routing;

namespace EnterLikeTab.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Teste1",
            //    url: "{conte}/{controller}/{action}",
            //    defaults: new { controller = "Home",action ="byjquery" }
            //);
            
            routes.MapRoute(
                name: "ByJavaScript",
                url: "byjavascript",
                defaults: new { controller = "Home", action = "ByJavaScript" }
            ); 
            
            routes.MapRoute(
                name: "ByJQuery",
                url: "byjquery",
                defaults: new { controller = "Home", action = "ByJQuery" }
            );
            
            routes.MapRoute(
                name: "ByPlusTab",
                url: "byplustab",
                defaults: new { controller = "Home", action = "ByPlusTab" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            
        }
    }
}
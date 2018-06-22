using System.Web.Http;

namespace WebApi.Test.App_Start
{
    public class WebApiConfig
    {
        public static void Configure(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "MyRestFullApp/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
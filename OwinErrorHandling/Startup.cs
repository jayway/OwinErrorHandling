using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using Microsoft.Owin;
using Owin;
using OwinErrorHandling;
using OwinErrorHandling.ErrorHandling;

[assembly: OwinStartup(typeof(Startup))]

namespace OwinErrorHandling
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());

            config.Services.Replace(typeof(IExceptionHandler), new OopsHandler());

            app
                .UseWebApi(config);
        }
    }
}
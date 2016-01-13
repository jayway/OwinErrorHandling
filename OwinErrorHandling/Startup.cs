using System;
using System.Net.Http.Formatting;
using System.Web.Http;
using Microsoft.Owin;
using Owin;
using OwinErrorHandling;

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

            app
                .UseWebApi(config);
        }
    }
}
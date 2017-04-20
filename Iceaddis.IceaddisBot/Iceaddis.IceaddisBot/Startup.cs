using System.Collections.Generic;
using System.Web.Http;
using Autofac;
using Iceaddis.IceaddisBot;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace Iceaddis.IceaddisBot
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);

            var config = new HttpConfiguration();

            ////configure dependency injection
            //var builder = RegisterControllers();
            //var container = builder.Build();
            //config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            
            config.MapHttpAttributeRoutes();

            config.EnsureInitialized();
            
            StatusLog.Logs = new List<string>();

            app.UseWebApi(config);

        }

        private static ContainerBuilder RegisterControllers()
        {
            var builder = new ContainerBuilder();
            builder.Register<ContainerBuilder>(c => builder);
            
            builder.Register<FacebookBotController>(c => new FacebookBotController());
            
            return builder;
        }

    }
}

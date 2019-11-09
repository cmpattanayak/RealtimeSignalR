using System;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

[assembly: OwinStartup(typeof(SignalrHubSelfHost.Startup))]

namespace SignalrHubSelfHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HubConfiguration configuration = new HubConfiguration
            {
                EnableDetailedErrors = true,
            };

            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR(configuration);
        }
    }
}

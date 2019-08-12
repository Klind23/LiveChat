using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(LiveChat.Startup))]

namespace LiveChat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
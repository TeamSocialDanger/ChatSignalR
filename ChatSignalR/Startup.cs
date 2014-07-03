using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatSignalR.Startup))]
namespace ChatSignalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}

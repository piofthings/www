using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

[assembly: OwinStartupAttribute(typeof(Piofthings.Web.Startup))]
namespace Piofthings.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors (CorsOptions.AllowAll);
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}

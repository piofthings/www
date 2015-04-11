using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Piofthings.Web.Startup))]
namespace Piofthings.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

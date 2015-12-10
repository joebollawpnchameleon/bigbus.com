using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigBus.Main.Web.Startup))]
namespace BigBus.Main.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

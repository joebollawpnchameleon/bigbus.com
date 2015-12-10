using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigBus.Agent.Web.Startup))]
namespace BigBus.Agent.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

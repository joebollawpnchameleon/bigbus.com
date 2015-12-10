using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigBus.BackOffice.Web.Startup))]
namespace BigBus.BackOffice.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

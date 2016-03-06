using Autofac;
using BigBus.BusinessServices.Implementation;
using BigBus.BusinessServices.Infrastructure;
using BigBus.DataServices.DataModel;
using BigBus.DataServices.Repositories.Infrastructure;
using BigBus.DataServices.Repositories.Implementation;
using BigBus.Authentication.Implementation;
using BigBus.Authentication.Infrastructure;
using CC = BigBus.Common.Constants;

namespace BigBus.Agent.Web.Depencies
{
    public class GeneralModule : Module
    {
        //private string connStr;

        public GeneralModule()
        {

        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TicketService>().As<ITicketService>().InstancePerRequest();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerRequest();
            builder.RegisterType<OckAuthService>().As<IOAuthService>()
                .WithParameter("cookieDomain", CC.Web.CookieDomainAgent)
                .WithParameter("cookiePrefix", CC.Web.CookiePrefixAgent)
                .WithParameter("cookieDuration", CC.Web.CookieDuration);
          
            builder.RegisterType<GenericDataRepository<Ticket>>().As<IGenericDataRepository<Ticket>>().InstancePerRequest();
            builder.RegisterType<GenericDataRepository<User>>().As<IGenericDataRepository<User>>().InstancePerRequest();
            builder.RegisterType<GenericDataRepository<Country>>().As<IGenericDataRepository<Country>>().InstancePerRequest();

            base.Load(builder);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using BigBus.BusinessServices;
using BigBus.BusinessServices.Implementation;
using BigBus.BusinessServices.Infrastructure;
using BigBus.DataServices.DataModel;
using BigBus.DataServices.Repositories.Infrastructure;
using BigBus.DataServices.Repositories.Implementation;
using BigBus.Authentication.Implementation;
using BigBus.Authentication.Infrastructure;

namespace BigBus.Agent.Web.Depencies
{
    public class GeneralModule : Module
    {
        //private string connStr;

        public GeneralModule()
        {
           // this.connStr = connString;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TicketService>().As<ITicketService>().InstancePerRequest();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerRequest();
            builder.RegisterType<OckAuthService>().As<IOAuthService>()
                .WithParameter("cookieDomain", "agent.bigbustours.com")
                .WithParameter("cookiePrefix", "BB_")
                .WithParameter("cookieDuration", 30);
          
            builder.RegisterType<GenericDataRepository<Ticket>>().As<IGenericDataRepository<Ticket>>().InstancePerRequest();
            builder.RegisterType<GenericDataRepository<User>>().As<IGenericDataRepository<User>>().InstancePerRequest();
            builder.RegisterType<GenericDataRepository<Country>>().As<IGenericDataRepository<Country>>().InstancePerRequest();

            //builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();

            base.Load(builder);
        }
    }
}

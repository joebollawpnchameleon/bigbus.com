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
            //builder.Register(c => new EFContext(this.connStr)).
            //                 As<IDbContext>().InstancePerRequest();

            builder.RegisterType<TicketService>().As<ITicketService>().InstancePerRequest();
            builder.RegisterType<GenericDataRepository<Ticket>>().As<IGenericDataRepository<Ticket>>().InstancePerRequest();

            //builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();

            base.Load(builder);
        }
    }
}

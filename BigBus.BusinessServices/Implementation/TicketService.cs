using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigBus.BusinessServices.Infrastructure;
using BigBus.DataServices;
using BigBus.DataServices.Repositories.Infrastructure;

namespace BigBus.BusinessServices.Implementation
{
    public class TicketService: ITicketService
    {
        private IGenericDataRepository<tb_Ticket> _ticketRepos;

        public TicketService(IGenericDataRepository<tb_Ticket> ticketRepository)
        {
            _ticketRepos = ticketRepository;
        }
    }
}

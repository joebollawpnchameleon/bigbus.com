using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigBus.BusinessServices.Infrastructure;
using BigBus.DataServices;
using BigBus.DataServices.DataModel;
using BigBus.DataServices.Repositories.Infrastructure;

namespace BigBus.BusinessServices.Implementation
{
    public class TicketService: ITicketService
    {
        private readonly IGenericDataRepository<Ticket> _ticketRepos;

        public TicketService(IGenericDataRepository<Ticket> ticketRepository)
        {
            _ticketRepos = ticketRepository;
        }

        public Ticket GetTicket(Guid ticketId)
        {
            return _ticketRepos.GetSingle(x => x.Id == ticketId);
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return _ticketRepos.GetAll();
        }
    }
}

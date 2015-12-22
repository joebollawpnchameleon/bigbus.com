using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigBus.DataServices.DataModel;

namespace BigBus.BusinessServices.Infrastructure
{
    public interface ITicketService
    {
        Ticket GetTicket(Guid ticketId);
    }
}

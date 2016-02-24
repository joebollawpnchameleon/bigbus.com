using System;
using System.Collections.Generic;
using BigBus.DataServices.DataModel;

namespace BigBus.BusinessServices.Infrastructure
{
    public interface ITicketService
    {
        Ticket GetTicket(Guid ticketId);

        IEnumerable<Ticket> GetAllTickets();
    }
}

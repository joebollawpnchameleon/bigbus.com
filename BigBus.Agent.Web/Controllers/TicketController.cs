using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BigBus.BusinessServices;
using BigBus.BusinessServices.Infrastructure;
using BigBus.DataServices;

namespace BigBus.Agent.Web.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTicket(string id)
        {
            var ticket = _ticketService.GetTicket(new Guid(id));

            return View(ticket);
        }
    }
}

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
    public class TicketController : BaseController
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
            if (string.IsNullOrEmpty(id))
            {
                RedirectToAction("ListAllTickets");
            }
            var ticket = _ticketService.GetTicket(new Guid(id));

            return View(ticket);
        }

        public ActionResult ListAllTickets()
        {
            return View("AllTickets", _ticketService.GetAllTickets());
        }
    }
}


using System.Web.Mvc;
using BigBus.Authentication.Implementation;
using BigBus.Authentication.Model;

namespace BigBus.Agent.Web.Controllers
{
    [CustomAuth( Roles.Agent, "agent.bigbustours.com","BB_",30)]
    public class BaseController : Controller
    {
    }
}

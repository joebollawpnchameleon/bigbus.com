
using System.Web.Mvc;
using BigBus.Authentication.Model;
using C = BigBus.Common.Constants;

namespace BigBus.Agent.Web.Controllers
{
    [CustomAuth(Roles.Agent, C.Web.CookieDomainAgent  , C.Web.CookiePrefixAgent,C.Web.CookieDuration)]
    public class BaseController : Controller
    {
    }
}

using BigBus.Agent.Web.Models;
using System;
using System.Web.Mvc;
using BigBus.BusinessServices.Infrastructure;
using BigBus.DataServices.DataModel;
using BigBus.Authentication.Model;
using BigBus.Authentication.Infrastructure;
using log4net;

namespace BigBus.Agent.Web.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IUserService _userService;
        private readonly IOAuthService _authService;

        private static readonly ILog Log = LogManager.GetLogger(typeof(AccountController));

        public AccountController(IUserService userService, IOAuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View(new LoginMV { ReferringUrl = (Request.UrlReferrer != null) ? Request.UrlReferrer.AbsoluteUri : "" });
        }


        [HttpPost]
        [AllowAnonymous]
        public ActionResult LoginUser(LoginMV userdetails)
        {
            if (!ModelState.IsValid)
                return null;

            //check that this user is agent and that is valid
            var user = _userService.FindUserForLogin(userdetails.UserName.Trim(), userdetails.Password);
                        
           
            if (user != null && user.IsAgent)
            {
                var clientUser = new ClientUser
                {
                    FullName = user.Firstname + " " + user.Lastname,
                    Id = user.Id,
                    Roles = new System.Collections.Generic.List<string> { Roles.Agent.ToString() },
                    MicrositeId = user.MicroSiteId,
                    Email = user.FriendlyEmail,
                    AgentRef = user.AgentProfileId
                };

                _authService.PersistClientUser(clientUser);

                ViewBag.IsUserLoggedIn = true;
                ViewBag.UserName = clientUser.FullName;

                if (!string.IsNullOrEmpty(userdetails.ReferringUrl))
                {
                    Response.Redirect(userdetails.ReferringUrl);
                }

                return View("Index", clientUser);
            }
            else
            {
                Log.Debug("Login failed for user - agent  " + userdetails.UserName);

                ModelState.AddModelError("LoginFailed", "Agent failed to login");
                return View("Login");
            }
        }
    }
}

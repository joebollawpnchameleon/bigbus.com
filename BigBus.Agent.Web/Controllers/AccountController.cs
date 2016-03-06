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
        private readonly ITranslationService _translationService;

        private static readonly ILog Log = LogManager.GetLogger(typeof(AccountController));

        public AccountController(IUserService userService, IOAuthService authService, ITranslationService translationService)
        {
            _userService = userService;
            _authService = authService;
            _translationService = translationService;
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

        public ActionResult LoginAgent(LoginMV agent)
        {
            var newLogin = new LoginMV
            {
                ReferringUrl = (Request.UrlReferrer != null) ? Request.UrlReferrer.AbsoluteUri : ""
            };

            if (!ModelState.IsValid)
            {
                return View("Login", newLogin);
            }

            var agentUser = _userService.LoginAgentUser(agent.UserName, agent.Password);

            if(agentUser == null)
            {
                ModelState.AddModelError("LoginFailed", _translationService.TranslateTerm("LoginFailed"));                
                return View("Login", newLogin);
            }
            else if (!agentUser.AgentProfile.Enabled)
            {
                ModelState.AddModelError("LoginFailed", _translationService.TranslateTerm("AgentLoginDisabled"));
                return View("Login", newLogin);
            }
           
            if (agentUser.AgentProfile.Enabled)
            {
                if (BasePage.CurrentMicroSite.IsActiveAgentTandC && (!(agent.IsAgentTandCAccepted)))
                {
                    // first time agent? show check box
                    // isAgentTandC.Visible = true;
                    // isAgentTandCCheck.Text = BasePage.GetTranslation("agentTermsAndConditionURLText");

                    Result = true;
                    //LoginThisUser.IsAgentTandCAccepted = true;
                    Session ThisSession = BasePage.GetSession() as Session;
                    //  isAgentTandC.Visible = false;
                    ObjectFactory ObjFactory = BasePage.GetObjectFactory();

                    ThisSession.AssociateWithUser(LoginThisUser);

                }
                else
                {

                    Result = true;
                    //LoginThisUser.IsAgentTandCAccepted = true;
                    Session ThisSession = BasePage.GetSession() as Session;
                    //  isAgentTandC.Visible = false;
                    ObjectFactory ObjFactory = BasePage.GetObjectFactory();

                    ThisSession.AssociateWithUser(LoginThisUser);
                }
            }
            
        }
    }
}

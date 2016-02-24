using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using BigBus.Authentication.Implementation;
using BigBus.Authentication.Infrastructure;
using log4net;


namespace BigBus.Authentication.Model
{
    public class CustomAuthAttribute : AuthorizeAttribute 
    {
        private IOAuthService _authService;
        private ClientUser _user;
        private static readonly ILog Log = LogManager.GetLogger(typeof(CustomAuthAttribute));
        
        public Roles[] RequiredRoles { get; set; }
        public string AccessDeniedMessage { get; set; }

        public CustomAuthAttribute(Roles role, string domain, string prefix, int durationInMinute)
            : base()
        {
            _authService = new OckAuthService(domain, prefix, durationInMinute);
            RequiredRoles = new Roles[] { role };
        }

        public CustomAuthAttribute(string domain, string prefix, int durationInMinute, params Roles[] roles)
            : base()
        {
            _authService = new OckAuthService(domain, prefix, durationInMinute); 
            RequiredRoles = roles;
        }
      
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            try
            {
                _user = _authService.GetClientUser();

                if (_user == null || _user.Roles.Count < 1)//user must be authenticated
                    return false;

                 return _user.IsInRole(RequiredRoles); 
            }
            catch(Exception ex)
            {
                Log.Debug("Authentication failed: " + ex.Message);
                return false;
            }
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (_user == null)
            {
                filterContext.Result = new RedirectToRouteResult(new
                RouteValueDictionary(new { controller = "Account", action = "Login" }));
            }
            else
            {
                if (filterContext.HttpContext.Request.IsAjaxRequest())
                {
                    var urlHelper = new UrlHelper(filterContext.RequestContext);
                    filterContext.Result = new JsonResult
                    {
                        Data = new
                        {
                            Error = "NotAuthorized",
                            LogOnUrl = urlHelper.Action("AccessDenied", "Error")
                        },
                        JsonRequestBehavior = JsonRequestBehavior.AllowGet
                    };
                } 

                filterContext.Result = new RedirectToRouteResult(new
                RouteValueDictionary(new { controller = "Error", action = "AccessDenied", ModelError = AccessDeniedMessage }));
            }
        }
    }
}

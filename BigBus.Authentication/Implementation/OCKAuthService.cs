using System.ComponentModel;
using System.Globalization;
using System.Web;
using BigBus.Authentication.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using BigBus.Authentication.Model;
using CM;
using log4net;

namespace BigBus.Authentication.Implementation
{
    public class OckAuthService : IOAuthService
    {
        protected const string CkNameUserId = "UserId";
        protected const string CkNameUserFullName = "UserName";
        protected const string CkNameEmail = "Email";
        protected const string CkNameLanguageId = "LanguageId";
        protected const string CkNameCompanyId = "CompanyId";
        protected const string CkNameMicrositeId = "MicrositeId";
        protected const string CkNameAgentRef = "AgentRef";
        protected const string CkNameProfiles = "Profiles";
        protected const string CkNameRoles = "Roles";

        protected readonly string _cookiePrefix = string.Empty;
        protected readonly string _cookieDomain = string.Empty;
        protected readonly TimeSpan _cookieDurationInMins;

        protected readonly HttpContext _context;
        protected readonly ClientUser _user = new ClientUser();
        protected static readonly ILog Log = LogManager.GetLogger(typeof(OckAuthService));


        public string UserFullName
        {
            get { return ReadEncryptedCookie<string>(CkNameUserFullName); }
        }

        public Guid UserId
        {
            get { return ReadEncryptedCookie<Guid>(CkNameUserId); }
        }

        public string MicrositeId
        {
            get { return ReadEncryptedCookie<string>(CkNameCompanyId); }
        }

        public string AgentRef
        {
            get { return ReadEncryptedCookie<string>(CkNameAgentRef); }
        }

        public string UserProfiles
        {
            get { return ReadEncryptedCookie<string>(CkNameProfiles); }
        }

        public string UserRoles
        {
            get { return ReadEncryptedCookie<string>(CkNameRoles); }
        }

        public string UserEmail
        {
            get { return ReadEncryptedCookie<string>(CkNameEmail); }
        }

        public OckAuthService()
        {
            _cookieDurationInMins = new TimeSpan(0, 0, 30, 0);
            _context = HttpContext.Current;
        }

        public OckAuthService(string cookieDomain, string cookiePrefix, int cookieDuration)
        {
            _context = HttpContext.Current;
            _cookiePrefix = cookiePrefix;
            _cookieDomain = cookieDomain;
            _cookieDurationInMins = new TimeSpan(0,0, cookieDuration,0);
        }

        public HttpCookie GenerateCookie(string cookieName, string cookieValue, TimeSpan tmDuration)
        {
            var cookie = new HttpCookie(_cookiePrefix + cookieName)
            {
                Value = !string.IsNullOrEmpty(cookieValue) ? cookieValue : "",
                Expires = DateTime.Now + tmDuration,
                Domain = _cookieDomain
            };

            return cookie;
        }

        public bool PlaceClientCookie(string cookieName, string ckValue, TimeSpan tmDuration)
        {
            var ck = GenerateCookie(cookieName, ckValue, tmDuration);
            HttpContext.Current.Response.Cookies.Add(ck);
            return true;
        }

        public bool DeleteClientCookie(string cookieName)
        {
            return PlaceClientCookie(cookieName, "", new TimeSpan(-1, 0, 0, 0));
        }

        /// <summary>
        /// Generates an encrypted cookie based on values supplied in parameters
        /// </summary>
        /// <param name="cookieName"></param>
        /// <param name="cookieValue"></param>
        /// <param name="tmDuration"></param>
        /// <returns></returns>
        public HttpCookie GenerateEncryptedCookie(string cookieName, string cookieValue, TimeSpan tmDuration)
        {
            var cookie = new HttpCookie(_cookiePrefix + cookieName)
                {
                    Value = !string.IsNullOrEmpty(cookieValue) ? Security.Encrypt(cookieValue) : "",
                    Expires = DateTime.Now + tmDuration,
                    Domain = _cookieDomain
                };

            return cookie;
        }

        /// <summary>
        /// Places an encrypted cookie to client.
        /// </summary>
        /// <param name="cookieName"></param>
        /// <param name="ckValue"></param>
        /// <param name="tmDuration"></param>
        /// <returns></returns>
        public bool PlaceClientEncryptedCookie(string cookieName, string ckValue, TimeSpan tmDuration)
        {
            var ck = GenerateEncryptedCookie(cookieName, ckValue, tmDuration);
            HttpContext.Current.Response.Cookies.Add(ck);
            return true;
        }

        /// <summary>
        /// Gets an encrypted cookie from client and returns type as requested
        /// </summary>
        /// <param name="cookieName"></param>
        /// <returns></returns>
        public T ReadEncryptedCookie<T>(string cookieName)
        {
              
                try
                {
                    var cookie = HttpContext.Current.Request.Cookies[_cookiePrefix + 
                        cookieName];
                    if (cookie == null || (!string.IsNullOrEmpty(cookie.Domain) && cookie.Domain != _cookieDomain))
                        return default(T);

                    var converter = TypeDescriptor.GetConverter(typeof(T));

                    if (converter.CanConvertFrom(typeof (string)))
                    {
                        string value = Security.Decrypt(cookie.Value);
                        return (T) converter.ConvertFromString(value);
                    }
                    else
                    {
                        return default(T);
                    }
                   
                }
                catch { return default(T); }
        }

        public virtual ClientUser GetClientUser()
        {
            try
            {
                var lstProfiles = !string.IsNullOrEmpty(UserProfiles)? 
                    (UserProfiles.Split(',').Select(s => s)).ToList() : new List<string>();

                var lstRoles = !string.IsNullOrEmpty(UserRoles)?
                    UserRoles.Split(',').Select(s => s).ToList() : new List<string>();

                return new ClientUser
                    {
                        Profiles = lstProfiles,
                        Roles = lstRoles,//user must have some roles
                        Id = UserId,
                        FullName = UserFullName,
                        MicrositeId = MicrositeId,
                        Email = UserEmail,
                        AgentRef = AgentRef
                    };
            }
            catch(Exception ex)
            {
                Log.Debug("GetUser - Could not compile user data" + ex.Message);
            }

            return null;
        }

        public virtual void PersistClientUser(ClientUser user)
        {
            try
            {
                var sProfiles = (user.Profiles != null && user.Profiles.Count > 0) ?
                    string.Join(",", user.Profiles.Select(x => x).ToArray()) : string.Empty;

                var sRoles = (user.Roles != null && user.Roles.Count > 0)?
                    string.Join(",", user.Roles.Select(x => x).ToArray()) : string.Empty;

                PlaceClientEncryptedCookie(CkNameUserId, user.Id.ToString(), _cookieDurationInMins);
                PlaceClientEncryptedCookie(CkNameEmail, user.Email, _cookieDurationInMins);
                PlaceClientEncryptedCookie(CkNameUserFullName, user.FullName, _cookieDurationInMins);
                PlaceClientEncryptedCookie(CkNameProfiles, sProfiles, _cookieDurationInMins);
                PlaceClientEncryptedCookie(CkNameRoles,sRoles , _cookieDurationInMins);
                PlaceClientEncryptedCookie(CkNameAgentRef, user.AgentRef, _cookieDurationInMins);
                PlaceClientEncryptedCookie(CkNameMicrositeId, user.MicrositeId.ToString(), _cookieDurationInMins);
            }
            catch (Exception ex)
            {
                Log.Debug("PersistUser - Failed to persist user data username " + user.FullName + " exception: " + Environment.NewLine + ex.Message);
            }
        }

        public virtual void LogUserOut()
        {
            try
            {
                DeleteClientCookie(CkNameUserId);
                DeleteClientCookie(CkNameEmail);
                DeleteClientCookie(CkNameUserFullName);
                DeleteClientCookie(CkNameProfiles);
                DeleteClientCookie(CkNameRoles);
                DeleteClientCookie(CkNameMicrositeId);
                DeleteClientCookie(CkNameAgentRef);
            }
            catch (Exception ex)
            {
                Log.Debug("LogUserOut failed." + ex.Message);
            }
        }

        public virtual bool IsUserLoggedIn()
        {
            return UserId != null && !string.IsNullOrEmpty(UserRoles) && 
                !string.IsNullOrEmpty(UserEmail) && !string.IsNullOrEmpty(UserFullName);
        }

        public bool IsAgentLoggedIn()
        {
            return UserId != null && !string.IsNullOrEmpty(UserRoles) && !string.IsNullOrEmpty(AgentRef);
        }
    }
}

using BigBus.BusinessServices.Infrastructure;
using BigBus.DataServices.Repositories.Infrastructure;
using BigBus.DataServices.DataModel;
using System.Web.Helpers;

namespace BigBus.BusinessServices.Implementation
{
    public class UserService : IUserService
    {
        private readonly IGenericDataRepository<User> _userRepository;

        private readonly IGenericDataRepository<Country> _countryRepository;

        public UserService(IGenericDataRepository<User> userRepository, IGenericDataRepository<Country> countryRepository)
        {
            _userRepository = userRepository;
            _countryRepository = countryRepository;
        }

        public User FindUserForLogin(string username, string password)
        {
            //testing only
            //return new User
            //{
            //    Firstname = "Concierge",
            //    Lastname = "The Palace Hotel",
            //    Id = new System.Guid("AA759EC2-FB59-4AC4-9676-0005D7D5ABB2"),
            //    MicroSiteId = "london",
            //    FriendlyEmail = "joe.bolla@wpnchameleon.co.uk",
            //    AgentProfileId = "CTPAC01",
            //    IsAgent = true
            //};
            //var guid = new System.Guid("F8BA69A5-9E79-4396-B8AD-015272094FE7");

            //var user = _userRepository.GetSingle(x => x.Id == guid);
            //return user;
            //consider adding crypto and validate password

            //var user = _userRepository.GetSingle(x => x.Email.Trim().Equals(username.Trim(), System.StringComparison.CurrentCultureIgnoreCase));

            //if (user != null)
            //{       
            //    //update user using old password functionality to new functionality based on version         
            //    if (user.PasswordVersion == 1 && user.Password == password.Trim())
            //    {
            //        user.PasswordHash = Crypto.HashPassword(password.Trim());
            //        user.PasswordVersion = 2;
            //        user.Password = null;
            //        _userRepository.Update(user);
            //        return user;
            //    }

            //    if (user.PasswordVersion == 2 && Crypto.VerifyHashedPassword(user.PasswordHash, password.Trim()) 
            //        && user.Enabled)
            //    {
            //        Result = true;

            //        base.BasePage.Log("Manager => Login: " + LoginThisManager.Email);
            //        base.BasePage.LogNow();
            //    }
            //    else
            //    {
            //        LoginLiteral.Text = string.Format("<p style=\"color:red\">{0}</p>", BasePage.GetTranslation("LoginFailed"));
            //    }
            //}
            return null;

        }

        public User LoginAgentUser(string username, string password)
        {
            var agent = _userRepository.GetSingle(x => 
                    (x.Email.Trim().Equals(username.Trim(), System.StringComparison.CurrentCultureIgnoreCase)
                    || x.FriendlyEmail.Trim().Equals(username.Trim(), System.StringComparison.CurrentCultureIgnoreCase))
                    && x.IsAgent 
                    );            
               
            if (agent != null && agent.AgentProfile != null)
            {
                if (agent.PasswordVersion == 1 && agent.Password == password.Trim())
                {
                    agent.PasswordHash = Crypto.HashPassword(password.Trim());
                    agent.PasswordVersion = 2;
                    agent.Password = null;
                    _userRepository.Update(agent);
                    return agent;                 
                }

                if (agent.Authorised && agent.PasswordVersion == 2 &&
                    Crypto.VerifyHashedPassword(agent.PasswordHash, password.Trim()))
                {
                    return agent;
                }                   
            }

            return null;
        }

    }
}

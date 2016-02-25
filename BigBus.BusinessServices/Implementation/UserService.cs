using BigBus.BusinessServices.Infrastructure;
using BigBus.DataServices.Repositories.Infrastructure;
using BigBus.DataServices.DataModel;

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
            return new User
            {
                Firstname = "Concierge",
                Lastname = "The Palace Hotel",
                Id = new System.Guid("AA759EC2-FB59-4AC4-9676-0005D7D5ABB2"),
                MicroSiteId = "london",
                FriendlyEmail = "joe.bolla@wpnchameleon.co.uk",
                AgentProfileId = "CTPAC01",
                IsAgent = true
            };
            //var guid = new System.Guid("F8BA69A5-9E79-4396-B8AD-015272094FE7");

            //var user = _userRepository.GetSingle(x => x.Id == guid);
            //return user;
            //consider adding crypto and validate password
        }
    
    }
}

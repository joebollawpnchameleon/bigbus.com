using BigBus.BusinessServices.Infrastructure;
using BigBus.DataServices.Repositories.Infrastructure;
using BigBus.DataServices.DataModel;

namespace BigBus.BusinessServices.Implementation
{
    public class UserService : IUserService
    {
        private readonly IGenericDataRepository<User> _userRepository;

        public UserService(IGenericDataRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public User FindUserForLogin(string username, string password)
        {
            return _userRepository.GetSingle(x => x.FriendlyEmail.Equals(username.Trim(), System.StringComparison.CurrentCultureIgnoreCase));
             //consider adding crypto and validate password
        }
    
    }
}

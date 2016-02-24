using BigBus.DataServices.DataModel;

namespace BigBus.BusinessServices.Infrastructure
{
    public interface IUserService
    {
        User FindUserForLogin(string username, string password);
    }
}

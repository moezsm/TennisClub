using TennisClubApi.Models;

namespace TennisClubApi.Contracts
{
    public interface IUserBusinessProvider
    {
        List<User> GetUsers();
        User GetUser(long id);

        User GetUserByUserTypeId(long userTypeId);

    }
}

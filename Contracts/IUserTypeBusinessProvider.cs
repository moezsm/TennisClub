using TennisClubApi.Models;

namespace TennisClubApi.Contracts
{
    public interface IUserTypeBusinessProvider
    {
        List<UserType> GetUserTypes();
        UserType GetUserType(long id);

        long GetUserId(string code);
    }
}

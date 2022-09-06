using TennisClubApi.Models;

namespace TennisClubApi.Contracts
{
    public interface IUserTypeBusinessProvider
    {
        List<UserType> GetUserTypes();
        UserType GetUserType(long id);

        long GetUserTypeId(string code);
    }
}

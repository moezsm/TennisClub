using System.Linq;
using TennisClubApi.Context;
using TennisClubApi.Contracts;
using TennisClubApi.Models;

namespace TennisClubApi.BusinessProviders
{
    public class UserTypeBusinessProvider : IUserTypeBusinessProvider
    {
        private TennisContext _tennisContext;
        public UserTypeBusinessProvider(TennisContext tennisContext)
        {
            _tennisContext = tennisContext;
        }
        public long GetUserTypeId(string code)
        {
            return _tennisContext.UserType.FirstOrDefault(s => s.Code == code).Id;
        }

        public UserType GetUserType(long id)
        {
            return _tennisContext.UserType.FirstOrDefault(s => s.Id == id);
        }

        public List<UserType> GetUserTypes()
        {
            return _tennisContext.UserType.ToList();
        }
    }
}

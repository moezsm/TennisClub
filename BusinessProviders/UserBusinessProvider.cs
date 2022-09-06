using TennisClubApi.Context;
using TennisClubApi.Contracts;
using TennisClubApi.Models;

namespace TennisClubApi.BusinessProviders
{
    public class UserBusinessProvider : IUserBusinessProvider
    {
        private TennisContext _tennisContext;
        public UserBusinessProvider(TennisContext tennisContext)
        {
            _tennisContext = tennisContext;
        }
        public User GetUser(long id)
        {
            return _tennisContext.User.FirstOrDefault(s => s.Id == id);
        }

        public User GetUserByUserTypeId(long userTypeId)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            return _tennisContext.User.ToList();
        }
    }
}

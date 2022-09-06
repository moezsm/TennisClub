using Microsoft.EntityFrameworkCore;
using TennisClubApi.Models;

namespace TennisClubApi.Context
{
    public class TennisContext  : DbContext 
    {
        public TennisContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<UserType> UserType { get; set; }

    }
}

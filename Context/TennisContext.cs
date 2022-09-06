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
        public DbSet<User> User { get; set; }
        public DbSet<TennisCourt> TennisCourt { get; set; }
        public DbSet<BookingType> BookingType { get; set; }
        public DbSet<CourtBooking> CourtBooking { get; set; }

    }
}

namespace TennisClubApi.Models
{
    public class CourtBooking
    {
        public long Id { get; set; }

        public BookingType BookingType { get; set; }

        public User User { get; set; }

        public string Name { get; set; }

        public DateTime Created { get; set; }

        public DateTime Date { get; set; }
    }
}

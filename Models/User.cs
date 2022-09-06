namespace TennisClubApi.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string FirstName { get; set; }

        public long Phone { get; set; }

        public DateTime CreatedDate { get; set; }

        public UserType UserType { get; set; }



    }
}

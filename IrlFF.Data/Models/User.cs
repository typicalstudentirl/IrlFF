namespace IrlFF.Data.Models
{

    public enum Role
    {
        Administrator,
        User
    }

    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Team Team { get; set; }
        public Role Role { get; set; }
        public string Token { get; set; }

    }
}
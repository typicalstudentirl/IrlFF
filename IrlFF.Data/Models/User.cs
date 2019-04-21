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
        public string UserName { get; set; }
        public string ForeName { get; set; }
        public string SurName { get; set; }
        public string Password { get; set; }
        public string TeamId { get; set; }
        public Team Team { get; set; }
        public Role Role { get; set; }
        public string Token { get; set; }
    }
}
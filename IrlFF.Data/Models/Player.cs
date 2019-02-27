namespace IrlFF.Data.Models
{
    public enum Position
    {
        Goalkeeper, Defender, Midfielder, Attacker
    }

    public class Player
    {
        public Player()
        {

        }

        public int Id { get; set; }

        public string Forename { get; set; }

        public string Surname { get; set; }

        public int WeekPoints { get; set; }

        public int TotalPoints { get; set; }

        public double PlayerValue { get; set; }

        public Position Position { get; set; }

        public int ClubId { get; set; }

        public Club Club { get; set; }

    }
}
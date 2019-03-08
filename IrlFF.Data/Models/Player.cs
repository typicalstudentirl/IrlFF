namespace IrlFF.Data.Models
{
    public enum Position
    {
        Goalkeeper = 1,
        Defender = 2 ,
        Midfielder = 3,
        Attacker = 4
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

        public int FK_Player_Club_ClubId { get; set; }

        public Club Club { get; set; }

    }
}
using System.Collections.Generic;

namespace IrlFF.Data.Models
{
    public class Team
    {
        public int Id { get; set; }

        public string Owner { get; set; }
        
        public string TeamName { get; set; }

        public int TotalPoints { get; set; }

        public int WeekPoints{ get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public ICollection<TeamPlayer> TeamPlayers { get; set; }
    }
}

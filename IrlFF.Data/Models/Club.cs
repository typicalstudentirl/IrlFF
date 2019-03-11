using System;
using System.Collections.Generic;
using System.Text;

namespace IrlFF.Data.Models
{
    public class Club //Principal entity
    {
        public int Id { get; set; } //Primary key property

        public string ClubName { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
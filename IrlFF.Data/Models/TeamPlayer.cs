using System;
using System.Collections.Generic;
using System.Text;

namespace IrlFF.Data.Models
{
    public class TeamPlayer
    {
        public int TeamId { get; set; }

        public Team Team { get; set; }

        public int PlayerId { get; set; }

        public Player Player { get; set; }
    }
}

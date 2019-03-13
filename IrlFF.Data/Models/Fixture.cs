using System;
using System.Collections.Generic;
using System.Text;

namespace IrlFF.Data.Models
{
    public class Fixture //Principal entity
    {
        public int Id { get; set; }

        public ICollection<Match> Matches { get; set; }
    }
}
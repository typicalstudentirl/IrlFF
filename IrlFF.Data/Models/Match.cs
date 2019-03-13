using System;
using System.Collections.Generic;
using System.Text;

namespace IrlFF.Data.Models
{
    public class Match
    {
        public int Id { get; set; }

        public string HomeClub { get; set; }

        public string AwayClub { get; set; }

        public DateTime Date { get; set; }

        public string Location { get; set; }

        public Fixture Fixture { get; set; }

        public int FixtureId { get; set; }
    }
}

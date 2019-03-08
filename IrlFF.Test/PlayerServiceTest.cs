using IrlFF.Data.Models;
using IrlFF.Data.Services;
using System.Collections.Generic;
using Xunit;

namespace IrlFF.Test
{
    public class PlayerServiceTest
    {
        private readonly IPlayerService svc;

        public PlayerServiceTest()
        {
            svc = new PlayerService();
            //Restore test data to DB before each test
            svc.Initialize();
        }

        //[Fact]
        //public void Add_New_Player_To_Empty_DB_Should_Be_Found()
        //{
        //    Player p = new Player { Forename = "Gregory", Surname = "Sloggett", WeekPoints = 12, TotalPoints = 24, ClubId = 1, PlayerValue = 5.0, Position = Position.Midfielder };

        //    p = svc.AddPlayer(p);

        //    Player newPlayer = svc.GetPlayerById(p.Id);

        //    Assert.NotNull(newPlayer);
        //    Assert.Equal(p, newPlayer);
        //}

        //[Fact]
        //public void Add_Players_And_Get_Players_List_Confirm_Equal()
        //{
        //    IList<Player> expectedPlayers = new List<Player>();

        //    Player p = new Player { Forename = "Barry", Surname = "McNamee", WeekPoints = 0, TotalPoints = 0, ClubId = 2, PlayerValue = 5.0, Position = Position.Midfielder };
        //    expectedPlayers.Add(p);

        //    Player p2 = new Player { Forename = "Gregory", Surname = "Sloggett", WeekPoints = 12, TotalPoints = 24, ClubId = 1, PlayerValue = 5.0, Position = Position.Midfielder };
        //    expectedPlayers.Add(p2);

        //    p = svc.AddPlayer(p);
        //    p2 = svc.AddPlayer(p2);

        //    IList<Player> actualPlayers = svc.GetPlayers();

        //    Assert.Equal(expectedPlayers, actualPlayers);
        //}

        //[Fact]
        //public void Add_Players_And_Get_Players_Order_By_WeekPoints()
        //{

        //    Player p = new Player { Forename = "Barry", Surname = "McNamee", WeekPoints = 0, TotalPoints = 0, ClubId = 2, PlayerValue = 5.0, Position = Position.Midfielder };

        //    Player p2 = new Player { Forename = "Gregory", Surname = "Sloggett", WeekPoints = 12, TotalPoints = 24, ClubId = 1, PlayerValue = 5.0, Position = Position.Midfielder };

        //    p = svc.AddPlayer(p);
        //    p2 = svc.AddPlayer(p2);

        //    IList<Player> actualPlayers = svc.GetPlayers("WeekPoints");

        //    Assert.Equal(12, actualPlayers[1].WeekPoints);
        //}

        //[Fact]
        //public void Add_Players_And_Get_Players_Order_By_TotalPoints()
        //{

        //    Player p = new Player { Forename = "Barry", Surname = "McNamee", WeekPoints = 0, TotalPoints = 0, ClubId = 2, PlayerValue = 5.0, Position = Position.Midfielder };

        //    Player p2 = new Player { Forename = "Gregory", Surname = "Sloggett", WeekPoints = 12, TotalPoints = 24, ClubId = 1, PlayerValue = 5.0, Position = Position.Midfielder };

        //    p = svc.AddPlayer(p);
        //    p2 = svc.AddPlayer(p2);

        //    IList<Player> actualPlayers = svc.GetPlayers("TotalPoints");

        //    Assert.Equal(24, actualPlayers[1].TotalPoints);
        //}

        //[Fact]
        //public void Add_Players_And_Get_Players_Order_By_PlayerValue()
        //{

        //    Player p = new Player { Forename = "Barry", Surname = "McNamee", WeekPoints = 0, TotalPoints = 0, ClubId = 2, PlayerValue = 5.0, Position = Position.Midfielder };

        //    Player p2 = new Player { Forename = "Gregory", Surname = "Sloggett", WeekPoints = 12, TotalPoints = 24, ClubId = 1, PlayerValue = 10.0, Position = Position.Midfielder };

        //    p = svc.AddPlayer(p);
        //    p2 = svc.AddPlayer(p2);

        //    IList<Player> actualPlayers = svc.GetPlayers("PlayerValue");

        //    Assert.Equal(10.0, actualPlayers[1].PlayerValue);
        //}

        //[Fact]
        //public void Add_Players_And_Get_Players_Order_By_Position_Defender()
        //{

        //    Player p = new Player { Forename = "Barry", Surname = "McNamee", WeekPoints = 0, TotalPoints = 0, ClubId = 2, PlayerValue = 5.0, Position = Position.Midfielder };

        //    Player p2 = new Player { Forename = "Darren", Surname = "Cole", WeekPoints = 12, TotalPoints = 24, ClubId = 1, PlayerValue = 10.0, Position = Position.Defender };

        //    p = svc.AddPlayer(p);
        //    p2 = svc.AddPlayer(p2);

        //    IList<Player> actualPlayers = svc.GetPlayers("Defender");

        //    Assert.Equal(Position.Defender, actualPlayers[0].Position);
        //}

        [Fact]
        public void Add_Players_And_Get_Players_By_Club()
        {

            Player p = new Player { Forename = "Barry", Surname = "McNamee", WeekPoints = 0, TotalPoints = 0, FK_Player_Club_ClubId = 1, PlayerValue = 5.0, Position = Position.Midfielder };

            Player p2 = new Player { Forename = "Darren", Surname = "Cole", WeekPoints = 12, TotalPoints = 24, FK_Player_Club_ClubId = 1, PlayerValue = 10.0, Position = Position.Defender };

            Player p3 = new Player { Forename = "Nathan", Surname = "Gartside", WeekPoints = 1, TotalPoints = 1, FK_Player_Club_ClubId = 1, PlayerValue = 4.0, Position = Position.Goalkeeper};

            Player p4 = new Player { Forename = "Junior", Surname = "Ogedi-Uzokwe", WeekPoints = 12, TotalPoints = 13, FK_Player_Club_ClubId = 1, PlayerValue = 11.0, Position = Position.Attacker };

            Player p5 = new Player { Forename = "Aaron", Surname = "McEneff", WeekPoints = 12, TotalPoints = 24, FK_Player_Club_ClubId = 2, PlayerValue = 10.0, Position = Position.Midfielder};
            p = svc.AddPlayer(p);
            p2 = svc.AddPlayer(p2);
            p3 = svc.AddPlayer(p3);
            p4 = svc.AddPlayer(p4);
            p5 = svc.AddPlayer(p5);

            IList<Player> actualPlayers = svc.GetPlayersByClub(1);

            Assert.Equal(4, actualPlayers.Count);
        }
    }
}

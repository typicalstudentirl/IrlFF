using IrlFF.Data.Models;
using IrlFF.Data.Services;
using System.Collections.Generic;
using Xunit;

namespace IrlFF.Test
{
    public class PlayerServiceTest
    {
        //private readonly IPlayerService svc;

        private readonly IPlayerService svc;

        public PlayerServiceTest()
        {
            svc = new PlayerService();
            //Restore test data to DB before each test
            svc.Initialize();
        }

        [Fact]
        public void Add_New_Player_To_Empty_DB_Should_Be_Found()
        {
            Player p = new Player { Forename = "Gregory", Surname = "Sloggett",  TotalPoints = 24, ClubId = 1, Position = Position.Midfielder };

            p = svc.AddPlayer(p);

            Player newPlayer = svc.GetPlayerById(p.Id);

            Assert.NotNull(newPlayer);
            Assert.Equal(p, newPlayer);
        }

        [Fact]
        public void Add_Players_And_Get_Players_List_Confirm_Equal()
        {
            IList<Player> expectedPlayers = new List<Player>();
            expectedPlayers = svc.GetPlayers();

            Player p = new Player { Forename = "Barry", Surname = "McNamee",  TotalPoints = 0, ClubId = 2, Position = Position.Midfielder };
            expectedPlayers.Add(p);

            Player p2 = new Player { Forename = "Gregory", Surname = "Sloggett",  TotalPoints = 24, ClubId = 1, Position = Position.Midfielder };
            expectedPlayers.Add(p2);

            p = svc.AddPlayer(p);
            p2 = svc.AddPlayer(p2);

            IList<Player> actualPlayers = svc.GetPlayers();

            Assert.Equal(expectedPlayers, actualPlayers);
        }

        [Fact]
        public void Add_Players_And_Get_Players_Order_By_TotalPoints()
        {

            Player p = new Player { Forename = "Barry", Surname = "McNamee",  TotalPoints = 0, ClubId = 2, Position = Position.Midfielder };

            Player p2 = new Player { Forename = "Gregory", Surname = "Sloggett",  TotalPoints = 24, ClubId = 1, Position = Position.Midfielder };

            p = svc.AddPlayer(p);
            p2 = svc.AddPlayer(p2);

            IList<Player> actualPlayers = svc.GetPlayers("TotalPoints");

            Assert.Equal(24, actualPlayers[2].TotalPoints);
        }

        [Fact]
        public void Add_Players_And_Get_Players_Order_By_Position_Defender()
        {

            Player p = new Player { Forename = "Barry", Surname = "McNamee",  TotalPoints = 0, ClubId = 2, Position = Position.Midfielder };

            Player p2 = new Player { Forename = "Darren", Surname = "Cole",  TotalPoints = 24, ClubId = 1, Position = Position.Defender };

            p = svc.AddPlayer(p);
            p2 = svc.AddPlayer(p2);

            IList<Player> actualPlayers = svc.GetPlayers("Defender");

            Assert.Equal(Position.Defender, actualPlayers[0].Position);
        }

        [Fact]
        public void Add_Players_And_Get_Players_By_Club()
        {

            Player p = new Player { Forename = "Barry", Surname = "McNamee",  TotalPoints = 0, ClubId = 1, Position = Position.Midfielder };

            Player p2 = new Player { Forename = "Darren", Surname = "Cole",  TotalPoints = 24, ClubId = 1, Position = Position.Defender };

            Player p3 = new Player { Forename = "Nathan", Surname = "Gartside", TotalPoints = 1, ClubId = 1, Position = Position.Goalkeeper};

            Player p4 = new Player { Forename = "Junior", Surname = "Ogedi-Uzokwe",  TotalPoints = 13, ClubId = 1, Position = Position.Forward };

            Player p5 = new Player { Forename = "Aaron", Surname = "McEneff",  TotalPoints = 24, ClubId = 2, Position = Position.Midfielder};
            p = svc.AddPlayer(p);
            p2 = svc.AddPlayer(p2);
            p3 = svc.AddPlayer(p3);
            p4 = svc.AddPlayer(p4);
            p5 = svc.AddPlayer(p5);

            IList<Player> actualPlayers = svc.GetPlayersByClub(1);

            Assert.Equal(5, actualPlayers.Count);
        }

        [Fact]
        public void Add_Player_Delete_Player_Check_If_Exists()
        {
            Player p = new Player { Forename = "Barry", Surname = "McNamee",  TotalPoints = 0, ClubId = 2, Position = Position.Midfielder };

            p = svc.AddPlayer(p);

            svc.DeletePlayer(p.Id);

            Assert.Null(svc.GetPlayerById(p.Id));
        }
    }
}

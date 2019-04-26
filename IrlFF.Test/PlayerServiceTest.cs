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
        public void PlayerService_AddPlayer_GetById_Success()
        {
            Player p = new Player { Forename = "Gregory", Surname = "Sloggett",  TotalPoints = 24, ClubId = 1, Position = Position.Midfielder };

            p = svc.AddPlayer(p);

            Player newPlayer = svc.GetPlayerById(p.Id);
            
            Assert.NotNull(newPlayer);
        }

        [Fact]
        public void PlayerService_AddPlayers_GetPlayers_Success()
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
        public void PlayerService_AddPlayers_GetByPoints_Success()
        {

            Player p = new Player { Forename = "Test", Surname = "Player",  TotalPoints = 1000, ClubId = 3, Position = Position.Midfielder };

            p = svc.AddPlayer(p);

            IList<Player> actualPlayers = svc.GetPlayers("TotalPoints");

            Assert.Equal(1000, actualPlayers[0].TotalPoints);
        }

        [Fact]
        public void PlayerService_AddPlayers_GetByPosition_Success()
        {

            Player p = new Player { Forename = "Barry", Surname = "McNamee",  TotalPoints = 0, ClubId = 2, Position = Position.Midfielder };

            Player p2 = new Player { Forename = "Darren", Surname = "Cole",  TotalPoints = 24, ClubId = 1, Position = Position.Defender };

            p = svc.AddPlayer(p);
            p2 = svc.AddPlayer(p2);

            IList<Player> actualPlayers = svc.GetPlayers("Defender");

            Assert.Equal(Position.Defender, actualPlayers[0].Position);
        }

        [Fact]
        public void PlayerService_GetPlayersByClub_Success()
        {
            int count = svc.GetPlayersByClub(3).Count;
            Player p = new Player { Forename = "Barry", Surname = "McNamee",  TotalPoints = 0, ClubId = 3, Position = Position.Midfielder };
            
            p = svc.AddPlayer(p);
            count = count + 1;
            IList<Player> actualPlayers = svc.GetPlayersByClub(3);

            Assert.Equal(count, actualPlayers.Count);
        }

        [Fact]
        public void PlayerService_DeletePlayer_Success()
        {
            svc.GetPlayerById(1);
            svc.DeletePlayer(1);

            Assert.Null(svc.GetPlayerById(1));
        }

        [Fact]
        public void PlayerService_UpdatePlayer_Success()
        {
            // Arrange
            Player p = new Player { Forename = "Test", Surname = "Player", TotalPoints = 1000, ClubId = 3, Position = Position.Midfielder };
            // Action
            p = svc.AddPlayer(p);
            p.TotalPoints = 1000;
            svc.UpdatePlayer(p);
            p = svc.GetPlayerById(p.Id);
            // Assert
            Assert.Equal(1000, p.TotalPoints);
        }
    }
}

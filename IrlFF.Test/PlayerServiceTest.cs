using IrlFF.Data.Models;
using IrlFF.Data.Services;
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

        [Fact]
        public void Add_New_Player_To_Empty_DB_Should_Be_Found()
        {
            Player p = new Player { Forename = "Gregory", Surname = "Sloggett", WeekPoints = 12, TotalPoints = 24, ClubId = 1, PlayerValue = 5.0, Position = Position.Midfielder };

            p = svc.AddPlayer(p);

            Player newPlayer = svc.GetPlayerById(p.Id);

            Assert.NotNull(newPlayer);
        }
    }
}

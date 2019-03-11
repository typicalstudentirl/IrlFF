using IrlFF.Data.Models;
using IrlFF.Data.Services;
using System.Collections.Generic;
using Xunit;

namespace IrlFF.Test
{
    public class TeamPlayerServiceTest
    {
        private readonly ITeamPlayerService svc;

        public TeamPlayerServiceTest()
        {
            svc = new TeamPlayerService();
            //Restore test data to DB before each test
            svc.Initialize();
        }

        [Fact]
        public void Add_TeamPlayer_To_Empty_DB_And_Be_Found()
        {
            TeamPlayer tp = new TeamPlayer { };

            tp = svc.AddTeamPlayer(1, 1);

            IList<TeamPlayer> teamPlayers = svc.GetPlayersByTeamId(1);

            Assert.NotNull(teamPlayers);
            Assert.Equal(tp, teamPlayers[0]);
        }
    }
}

using IrlFF.Data.Models;
using IrlFF.Data.Services;
using System.Collections.Generic;
using Xunit;

namespace IrlFF.Test
{
    public class TeamPlayerServiceTest
    {
        private readonly ITeamPlayerService svc;
        private readonly IPlayerService playerSvc;
        private readonly ITeamService teamSvc;
        private readonly IUserService userSvc;

        public TeamPlayerServiceTest()
        {
            svc = new TeamPlayerService();
            playerSvc = new PlayerService();
            teamSvc = new TeamService();
            userSvc = new UserService();
            //Restore test data to DB before each test
            svc.Initialize();
        }

        [Fact]
        public void TeamPlayerService_AddTeamPlayer_Success()
        {
            TeamPlayer tp = new TeamPlayer { };

            // Create user
            User u = new User { ForeName = "Test", SurName = "Test", Password = "Test", Role = Role.User, UserName = "TestTest" };
            u.Id = userSvc.RegisterUser(u);
            // Create team matching user Id
            Team t = new Team { Forename = "Test", Surname = "Test", TeamName = "TestTeamName", UserId = u.Id };
            t = teamSvc.AddTeam(t);
            // Add TP to team matching team id
            tp = svc.AddTeamPlayer(t.Id, 1);

            IList<Player> actualTeamPlayers = svc.GetPlayersByTeamId(t.Id);

            Player expectedP = playerSvc.GetPlayerById(1);

            Assert.Equal(expectedP.Id, actualTeamPlayers[0].Id);
        }

        //[Fact]
        //public void TeamPlayerService_AddTeamPlayer_DelteTeamPlayer_Success()
        //{
        //    TeamPlayer tp = new TeamPlayer { };

        //    // Create user
        //    User u = new User { ForeName = "Test", SurName = "Test", Password = "Test", Role = Role.User, UserName = "TestTest" };
        //    u.Id = userSvc.RegisterUser(u);
        //    // Create team matching user Id
        //    Team t = new Team { Forename = "Test", Surname = "Test", TeamName = "TestTeamName", UserId = u.Id };
        //    t = teamSvc.AddTeam(t);
        //    // Add TP to team matching team id
        //    tp = svc.AddTeamPlayer(t.Id, 1);

        //    IList<Player> actualTeamPlayers = svc.GetPlayersByTeamId(t.Id);

        //    Player expectedP = playerSvc.GetPlayerById(1);

        //    svc.DeleteTeamPlayer(1, t.Id);

        //    Assert.DoesNotContain(expectedP, actualTeamPlayers);
        //}
    }
}

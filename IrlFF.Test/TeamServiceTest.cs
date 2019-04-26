using IrlFF.Data.Models;
using IrlFF.Data.Services;
using System.Collections.Generic;
using Xunit;

namespace IrlFF.Test
{
    public class TeamServiceTest
    {
        private readonly ITeamService svc;
        private readonly IUserService userSvc;
        public TeamServiceTest()
        {
            svc = new TeamService();
            userSvc = new UserService();
            //Restore test data to DB before each test
            svc.Initialize();
            
        }
        
        [Fact]
        public void TeamService_AddTeam_GetTeams_Success()
        {
            IList<Team> teamTest = svc.GetTeams();

            User u = new User { ForeName = "Test", SurName = "Test", Password = "Test", Role = Role.User, UserName = "TestUsername" };
            u.Id = userSvc.RegisterUser(u);
            Team t = new Team { Forename = "Test", Surname = "Test", TeamName = "TestTeamName", UserId = u.Id };
            teamTest.Add(t);

            t = svc.AddTeam(t);

            IList<Team> teams = svc.GetTeams();

            Assert.Equal(teams, teamTest);
        }

        [Fact]
        public void TeamService_UpdateTeamPoints_GetTeamById_Success()
        {
            User u = new User { ForeName = "Test", SurName = "Test", Password = "Test", Role = Role.User, UserName = "TestUsername" };
            userSvc.RegisterUser(u);
            Team t = new Team { Forename = "Test", Surname = "Test", TeamName = "TestTeamName", UserId = u.Id };
            t = svc.AddTeam(t);
            t.TotalPoints = 20;
            svc.UpdateTeam(t);
            t = svc.GetTeamById(t.Id);

            Assert.Equal(20, t.TotalPoints);
        }
    }
}

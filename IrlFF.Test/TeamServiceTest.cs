using IrlFF.Data.Models;
using IrlFF.Data.Services;
using System.Collections.Generic;
using Xunit;

namespace IrlFF.Test
{
    public class TeamServiceTest
    {
        private readonly ITeamService svc;

        public TeamServiceTest()
        {
            svc = new TeamService();
            //Restore test data to DB before each test
            svc.Initialize();
        }

        [Fact]
        public void Add_New_Team_Should_Be_Found()
        {
            Team t = new Team { Forename = "Stephen", Surname = "McGowan", TeamName = "Fantasy Eleven" };

            t = svc.AddTeam(t);

            Team t2 = svc.GetTeamById(t.Id);

            Assert.Equal(t, t2);
        }

        [Fact]
        public void Add_New_Clubs_To_Empty_DB_Should_Be_Found()
        {
            IList<Team> teamTest = svc.GetTeams();

            Team t = new Team { Forename = "Stephen", Surname = "McGowan", TeamName = "Galacticos" };
            teamTest.Add(t);
            Team t2 = new Team { Forename = "Lee", Surname = "Deehan", TeamName = "Best XI" };
            teamTest.Add(t2);

            t = svc.AddTeam(t);
            t2 = svc.AddTeam(t2);

            IList<Team> teams = svc.GetTeams();

            Assert.Equal(teams, teamTest);
        }

        [Fact]
        public void Update_Existing_Club_Check_Result()
        {
            Team t = new Team { Forename = "Stephen", Surname = "McGowan", TeamName = "Galacticos" };
            t = svc.AddTeam(t);
            t.TotalPoints = 20;
            svc.UpdateTeam(t);
            t = svc.GetTeamById(t.Id);

            Assert.Equal(20, t.TotalPoints);
        }
    }
}

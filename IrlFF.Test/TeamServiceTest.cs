using IrlFF.Data.Models;
using IrlFF.Data.Services;
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
    }
}

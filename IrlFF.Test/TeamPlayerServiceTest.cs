using IrlFF.Data.Models;
using IrlFF.Data.Services;
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
    }
}

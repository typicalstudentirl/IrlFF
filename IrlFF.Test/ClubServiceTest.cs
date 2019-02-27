using IrlFF.Data.Models;
using IrlFF.Data.Services;
using Xunit;

namespace IrlFF.Test
{
    public class ClubServiceTest
    {
        private readonly IClubService svc;

        public ClubServiceTest()
        {
            svc = new ClubService();
            //Restore test data to DB before each test
            svc.Initialize();
        }
    }
}

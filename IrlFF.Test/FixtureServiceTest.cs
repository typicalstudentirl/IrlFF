using IrlFF.Data.Models;
using IrlFF.Data.Services;
using System.Collections.Generic;
using Xunit;

namespace IrlFF.Test
{
    public class FixtureServiceTest
    {
        private readonly IFixtureService svc;

        public FixtureServiceTest()
        {
            svc = new FixtureService();
            //Restore test data to DB before each test
            svc.Initialize();
        }

        [Fact]
        public void GetFixtures_Not_Null()
        {
            IList<Fixture> f = svc.GetFixtures();

            Assert.NotNull(f);
        }
    }
}

using IrlFF.Data.Models;
using System.Collections.Generic;

namespace IrlFF.Data.Services
{
    public interface IFixtureService
    {
        void Initialize();

        IList<Fixture> GetFixtures();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IrlFF.Data.Models;
using IrlFF.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace IrlFF.Data.Services
{
    public class FixtureService : IFixtureService
    {
        private readonly FFDbContext ctx;

        public FixtureService()
        {
            ctx = FFDbContextFactory.CreateCtx();
        }
        public FixtureService(FFDbContext _ctx)
        {
            ctx = _ctx;
        }

        public void Initialize()
        {
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
        }

        public IList<Fixture> GetFixtures()
        {
            var fixture = ctx.Fixture
                .Include(f => f.Matches)
                .ToList();

            return fixture;
        }
        //return ctx.Player.Include(p => p.Club).Where(p => p.ClubId.Equals(ClubId)).ToList();
    }
}

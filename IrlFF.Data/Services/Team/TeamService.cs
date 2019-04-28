using IrlFF.Data.Models;
using IrlFF.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace IrlFF.Data.Services
{
    public class TeamService : ITeamService
    {
        private readonly FFDbContext ctx;

        public TeamService()
        {
            ctx = FFDbContextFactory.CreateCtx();
        }
        public TeamService(FFDbContext _ctx)
        {
            ctx = _ctx;
        }

        public void Initialize()
        {
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
        }

        public Team AddTeam(Team t)
        {
            t.Id = t.UserId;
            ctx.Team.Add(t);
            ctx.Database.OpenConnection();
            // Disable identity column temporarily to allow teamid = userid, then re-enable.
            try
            {
                ctx.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Team ON");
                ctx.SaveChanges();
                ctx.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Team OFF");
            }
            finally
            {
                ctx.Database.CloseConnection();
            }
            return t;
        }

        public Team GetTeamById(int id)
        {
            return ctx.Team
                    .AsNoTracking()
                    .FirstOrDefault(p => p.Id == id);
        }

        public IList<Team> GetTeams(string orderBy)
        {
            switch (orderBy)
            {
                case "TotalPoints":
                    return ctx.Team.OrderByDescending(c => c.TotalPoints).ToList();
                default:
                    return ctx.Team.ToList();
            }
        }

        public bool UpdateTeam(Team t)
        {
            Team team = GetTeamById(t.Id);
            if (team == null)
            {
                return false;
            }
            ctx.Attach(t).State = EntityState.Modified;
            ctx.SaveChanges();
            return true;
        }
    }
}

using IrlFF.Data.Models;
using IrlFF.Data.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace IrlFF.Data.Services
{
    public class TeamService : ITeamService
    {
        private readonly FFDbContext ctx;

        public TeamService()
        {
            ctx = new FFDbContext();
        }

        public void Initialize()
        {
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
        }

        public Team AddTeam(Team t)
        {
            ctx.Team.Add(t);
            ctx.SaveChanges();
            return t;
        }

        public Team GetTeamById(int id)
        {
            return ctx.Team
                    .FirstOrDefault(p => p.Id == id);
        }

        public IList<Team> GetTeams(string orderBy)
        {
            switch (orderBy)
            {
                case "TotalPoints":
                    return ctx.Team.OrderBy(c => c.TotalPoints).ToList();
                default:
                    return ctx.Team.ToList();
            }
        }
    }
}

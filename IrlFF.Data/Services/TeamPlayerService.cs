using IrlFF.Data.Models;
using IrlFF.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IrlFF.Data.Services
{
    public class TeamPlayerService : ITeamPlayerService
    {
        private readonly FFDbContext ctx;

        public TeamPlayerService()
        {
            ctx = new FFDbContext();
        }

        public void Initialize()
        {
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
        }

        public TeamPlayer AddTeamPlayer(int TeamId, int PlayerId)
        {
            TeamPlayer tp = new TeamPlayer  { TeamId = TeamId, PlayerId = PlayerId};

            ctx.TeamPlayer.Add(tp);
            ctx.SaveChanges();
            return tp;
        }

        public IList<TeamPlayer> GetPlayersByTeamId(int teamId)
        {
            return ctx.TeamPlayer.Include(tp => tp.Player)
                .Include(teamPlayer => teamPlayer.Team)
                .Include(teamPlayer => teamPlayer.Player)
                .Where(teamPlayer => teamPlayer.TeamId.Equals(teamId)).ToList();
        }
    }
}

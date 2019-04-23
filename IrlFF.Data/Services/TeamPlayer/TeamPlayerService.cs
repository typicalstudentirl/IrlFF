using IrlFF.Data.Models;
using IrlFF.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

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
            TeamPlayer tp = new TeamPlayer { TeamId = TeamId, PlayerId = PlayerId };

            ctx.TeamPlayer.Add(tp);
            try
            {
                ctx.SaveChanges();
                return tp;
            }
            catch (DbUpdateException e)
            {
                throw e;
            }
        }

        public IList<Player> GetPlayersByTeamId(int teamId)
        {
            // Access DBContext, return all TeamPlayers where id = id
            List<TeamPlayer> tps = 
                ctx.TeamPlayer
                .Include(tp => tp.Player)
                .ThenInclude(player => player.Club)
                .Where(teamPlayer => teamPlayer.TeamId.Equals(teamId)).ToList();
            List<Player> players = new List<Player>();

            // Loop team players and add all players to player list, return players online
            foreach (TeamPlayer teamPlayer in tps)
            {
                players.Add(teamPlayer.Player);
            }
            return players;
        }

        public bool DeleteTeamPlayer(int teamId, int playerId)
        {
            TeamPlayer teamPlayer = new TeamPlayer
            {
                TeamId = teamId,
                PlayerId = playerId
            };
            ctx.TeamPlayer.Remove(teamPlayer);
            ctx.SaveChanges();
            return true;
        }
    }
}

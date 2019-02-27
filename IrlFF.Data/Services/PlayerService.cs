using IrlFF.Data.Models;
using IrlFF.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace IrlFF.Data.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly FFDbContext ctx;

        public PlayerService()
        {
            ctx = new FFDbContext();
        }

        public void Initialize()
        {
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
        }

        // Player Service methods

        public Player AddPlayer(Player p)
        {
            ctx.Player.Add(p);
            ctx.SaveChanges();
            return p;
        }

        public Player GetPlayerById(int id)
        {
            return ctx.Player
                .FirstOrDefault(p => p.Id == id);
        }

        public List<Player> GetPlayers(string orderBy = null)
        {
            switch (orderBy)
            {
                case "WeekPoints":
                    return ctx.Player.OrderBy(p => p.WeekPoints).ToList();
                case "TotalPoints":
                    return ctx.Player.OrderBy(p => p.TotalPoints).ToList();
                case "PlayerValue":
                    return ctx.Player.OrderBy(m => m.PlayerValue).ToList();
                case "Position":
                    return ctx.Player.OrderBy(p => p.Position).ToList();
                default:
                    return ctx.Player.ToList();
            }
        }

        public List<Player> GetPlayersByClub(int ClubId)
        {
            return ctx.Player.Include(p => p.ClubId).Where(p => p.ClubId.Equals(ClubId)).ToList();
        }

        public bool UpdatePlayer(Player p)
        {
            ctx.Attach(p).State = EntityState.Modified;
            ctx.SaveChanges();
            return true;
        }

        public bool DeletePlayer(int id)
        {
            Player p = GetPlayerById(id);
            if (p == null)
            {
                return false;
            }

            ctx.Player.Remove(p);
            ctx.SaveChanges();
            return true;
        }
    }
}

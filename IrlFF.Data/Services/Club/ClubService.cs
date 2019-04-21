using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IrlFF.Data.Models;
using IrlFF.Data.Repositories;

namespace IrlFF.Data.Services
{
    public class ClubService : IClubService
    {
        private readonly FFDbContext ctx;

        public ClubService()
        {
            ctx = new FFDbContext();
        }

        public void Initialize()
        {
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
        }
        public Club AddClub(Club c)
        {
            ctx.Club.Add(c);
            ctx.SaveChanges();
            return c;
        }

        public Club GetClubById(int id)
        {
            return ctx.Club
                .FirstOrDefault(c => c.Id == id);
        }

        public IList<Club> GetClubs()
        {
            return ctx.Club.ToList();
        }

        public bool DeleteClub(int id)
        {
            Club c = GetClubById(id);
            if (c == null)
            {
                return false;
            }

            ctx.Club.Remove(c);
            ctx.SaveChanges();
            return true;
        }
    }
}

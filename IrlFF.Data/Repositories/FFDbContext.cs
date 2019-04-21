using IrlFF.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace IrlFF.Data.Repositories
{
    public class FFDbContext : DbContext
    {
        public DbSet<Player> Player { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<TeamPlayer> TeamPlayer { get; set; }
        public DbSet<Club> Club { get; set; }
        public DbSet<Fixture> Fixture { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Match> Matches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = IrlFF; Trusted_Connection = True; ConnectRetryCount = 0;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamPlayer>()
                .HasKey(tp => new { tp.TeamId, tp.PlayerId });

            modelBuilder.Entity<Fixture>()
                .HasData(new Fixture { Id = 1 } );

            modelBuilder.Entity<User>()
                .HasIndex(u => u.UserName)
                .IsUnique();

            #region Matches
            modelBuilder.Entity<Match>()
                .HasData(
                            new Match { Id = 1, HomeClub = "Waterford", AwayClub = "Shamrock Rovers", Date = new DateTime(2019, 2, 15, 20, 0, 0), Location = "Waterford Regional Sports Centre", FixtureId = 1 },
                            new Match { Id = 2, HomeClub = "St. Pats", AwayClub = "Cork City", Date = new DateTime(2019, 2, 12, 19, 45, 0), Location = "Richmond Park", FixtureId = 1 },
                            new Match { Id = 3, HomeClub = "Dundalk", AwayClub = "Sligo Rovers", Date = new DateTime(2019, 2, 12, 19, 45, 0), Location = "Oriel Park", FixtureId = 1 },
                            new Match { Id = 4, HomeClub = "Derry City", AwayClub = "U.C.D", Date = new DateTime(2019, 2, 12, 20, 19, 45), Location = "The Brandywell Stadium", FixtureId = 1 },
                            new Match { Id = 5, HomeClub = "Bohemians", AwayClub = "Finn Harps", Date = new DateTime(2019, 2, 12, 20, 0, 0), Location = "Dalymount Park", FixtureId = 1 }
                );
            #endregion

            #region Clubs
            modelBuilder.Entity<Club>()
                .HasData(new Club
            {
                Id = 1,
                ClubName = "Bohemians FC"
            },
            new Club
            {
                Id = 2,
                ClubName = "Cork City"
            },
            new Club
            {
                Id = 3,
                ClubName = "Derry City"
            },
            new Club
            {
                Id = 4,
                ClubName = "Dundalk FC"
            },
            new Club
            {
                Id = 5,
                ClubName = "Finn Harps"
            },
            new Club
            {
                Id = 6,
                ClubName = "Shamrock Rovers"
            },
            new Club
            {
                Id = 7,
                ClubName = "Sligo Rovers"
            },
            new Club
            {
                Id = 8,
                ClubName = "St. Pats"
            },
            new Club
            {
                Id = 9,
                ClubName = "Waterford"
            },
            new Club
            {
                Id = 10,
                ClubName = "U.C.D"
            });
            #endregion
        }
    }
}
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
                //.UseSqlServer(@"Server=tcp:irlff.database.windows.net,1433;Initial Catalog=IrlFFDb;Persist Security Info=False;User ID={your_username};Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                .UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = IrlFFTest; Trusted_Connection = True; ConnectRetryCount = 0;");
            optionsBuilder.EnableSensitiveDataLogging();
        }
        
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamPlayer>()
                .HasKey(tp => new { tp.TeamId, tp.PlayerId });

            modelBuilder.Entity<Fixture>()
                .HasData(
                new Fixture { Id = 1 },
                new Fixture { Id = 2 }
                );

            modelBuilder.Entity<User>()
                .HasIndex(u => u.UserName)
                .IsUnique();
            
            #region Players
            modelBuilder.Entity<Player>()
                .HasData(
                new Player
                {
                    Id = 1,
                    Forename = "Peter",
                    Surname = "Cherrie",
                    TotalPoints = 4,
                    Position = Position.Goalkeeper,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 2,
                    Forename = "Nathan",
                    Surname = "Gartside",
                    TotalPoints = 2,
                    Position = Position.Goalkeeper,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 3,
                    Forename = "Rhys",
                    Surname = "McDermott",
                    TotalPoints = 0,
                    Position = Position.Defender,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 4,
                    Forename = "Connor",
                    Surname = "McDermott",
                    TotalPoints = 4,
                    Position = Position.Defender,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 5,
                    Forename = "Ciaran",
                    Surname = "Coll",
                    TotalPoints = 1,
                    Position = Position.Defender,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 6,
                    Forename = "Eoin",
                    Surname = "Toal",
                    TotalPoints = 0,
                    Position = Position.Defender,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 7,
                    Forename = "Patrick",
                    Surname = "McClean",
                    TotalPoints = 0,
                    Position = Position.Defender,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 8,
                    Forename = "Darren",
                    Surname = "Cole",
                    TotalPoints = 0,
                    Position = Position.Defender,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 9,
                    Forename = "Josh",
                    Surname = "Kerr",
                    TotalPoints = 0,
                    Position = Position.Defender,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 10,
                    Forename = "Ally",
                    Surname = "Gilchrist",
                    TotalPoints = 0,
                    Position = Position.Defender,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 11,
                    Forename = "Brendan",
                    Surname = "Barr",
                    TotalPoints = 0,
                    Position = Position.Midfielder,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 12,
                    Forename = "Conor",
                    Surname = "Gormley",
                    TotalPoints = 0,
                    Position = Position.Midfielder,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 13,
                    Forename = "Ciaron",
                    Surname = "Harkin",
                    TotalPoints = 0,
                    Position = Position.Midfielder,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 14,
                    Forename = "Greg",
                    Surname = "Sloggett",
                    TotalPoints = 0,
                    Position = Position.Midfielder,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 15,
                    Forename = "Jamie",
                    Surname = "McDonagh",
                    TotalPoints = 0,
                    Position = Position.Midfielder,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 16,
                    Forename = "Gerardo",
                    Surname = "Bruna",
                    TotalPoints = 0,
                    Position = Position.Midfielder,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 17,
                    Forename = "Adrian",
                    Surname = "Delap",
                    TotalPoints = 0,
                    Position = Position.Midfielder,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 18,
                    Forename = "Evan",
                    Surname = "Tweed",
                    TotalPoints = 0,
                    Position = Position.Midfielder,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 19,
                    Forename = "Shane",
                    Surname = "McNamee",
                    TotalPoints = 0,
                    Position = Position.Midfielder,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 20,
                    Forename = "Gianni",
                    Surname = "Seraf",
                    TotalPoints = 0,
                    Position = Position.Midfielder,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 21,
                    Forename = "Barry",
                    Surname = "McNamee",
                    TotalPoints = 0,
                    Position = Position.Midfielder,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 22,
                    Forename = "Ronan",
                    Surname = "McKinley",
                    TotalPoints = 0,
                    Position = Position.Midfielder,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 23,
                    Forename = "David",
                    Surname = "Parkhouse",
                    TotalPoints = 0,
                    Position = Position.Forward,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 24,
                    Forename = "Michael",
                    Surname = "McCrudden",
                    TotalPoints = 0,
                    Position = Position.Forward,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 25,
                    Forename = "Junior",
                    Surname = "Ogedi-Uzokwe",
                    TotalPoints = 0,
                    Position = Position.Forward,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 26,
                    Forename = "Eoghan",
                    Surname = "Stokes",
                    TotalPoints = 0,
                    Position = Position.Forward,
                    ClubId = 3,
                });
            #endregion

            #region Matches
            modelBuilder.Entity<Match>()
                .HasData(
                            new Match { Id = 1, HomeClub = "Waterford", AwayClub = "Shamrock Rovers", Date = new DateTime(2019, 2, 15, 20, 0, 0), Location = "Waterford RSC", FixtureId = 1 },
                            new Match { Id = 2, HomeClub = "St. Pats", AwayClub = "Cork City", Date = new DateTime(2019, 2, 12, 15, 45, 0), Location = "Richmond Park", FixtureId = 1 },
                            new Match { Id = 3, HomeClub = "Dundalk", AwayClub = "Sligo Rovers", Date = new DateTime(2019, 2, 15, 19, 45, 0), Location = "Oriel Park", FixtureId = 1 },
                            new Match { Id = 4, HomeClub = "Derry City", AwayClub = "U.C.D", Date = new DateTime(2019, 2, 15, 20, 19, 45), Location = "The Brandywell Stadium", FixtureId = 1 },
                            new Match { Id = 5, HomeClub = "Bohemians", AwayClub = "Finn Harps", Date = new DateTime(2019, 2, 15, 20, 0, 0), Location = "Dalymount Park", FixtureId = 1 },

                            new Match { Id = 6, HomeClub = "Cork City", AwayClub = "Waterford", Date = new DateTime(2019, 2, 22, 20, 0, 0), Location = "Turner's Cross", FixtureId = 2 },
                            new Match { Id = 7, HomeClub = "Shamrock Rovers", AwayClub = "Derry City", Date = new DateTime(2019, 2, 22, 19, 45, 0), Location = "Tallaght Stadium", FixtureId = 2 },
                            new Match { Id = 8, HomeClub = "Finn Harps", AwayClub = "Dundalk", Date = new DateTime(2019, 2, 22, 19, 45, 0), Location = "Finn Park", FixtureId = 2 },
                            new Match { Id = 9, HomeClub = "U.C.D", AwayClub = "Bohemians", Date = new DateTime(2019, 2, 22, 20, 19, 45), Location = "U.C.D Bowl", FixtureId = 2 },
                            new Match { Id = 10, HomeClub = "Sligo Rovers", AwayClub = "St. Pats", Date = new DateTime(2019, 2, 22, 20, 0, 0), Location = "The Showgrounds", FixtureId = 2 }
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
                    ClubName = "U.C.D"
                },
                new Club
                {
                    Id = 10,
                    ClubName = "Waterford"
                });
            #endregion
        }
    }
}
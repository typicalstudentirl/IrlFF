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
        
        // DB Context Constructor for Startup -- error on parameterless constructor.
        public FFDbContext(DbContextOptions<FFDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamPlayer>()
                .HasKey(tp => new { tp.TeamId, tp.PlayerId });

            #region Fixtures
            modelBuilder.Entity<Fixture>()
                .HasData(
                new Fixture { Id = 1 }, new Fixture { Id = 2 },
                new Fixture { Id = 3 }, new Fixture { Id = 4 },
                new Fixture { Id = 5 }, new Fixture { Id = 6 },
                new Fixture { Id = 7 }, new Fixture { Id = 8 },
                new Fixture { Id = 9 }, new Fixture { Id = 10 },
                new Fixture { Id = 11 }, new Fixture { Id = 12 },
                new Fixture { Id = 13 }, new Fixture { Id = 14 },
                new Fixture { Id = 15 }, new Fixture { Id = 16 },
                new Fixture { Id = 17 }, new Fixture { Id = 18 },
                new Fixture { Id = 19 }, new Fixture { Id = 20 }
                );
            #endregion

            modelBuilder.Entity<User>()
                .HasIndex(u => u.UserName)
                .IsUnique();

            #region Players
            modelBuilder.Entity<Player>()
            .HasData(
            #region Bohemians
            new Player
            {
                Id = 27,
                Forename = "James",
                Surname = "Talbot",
                TotalPoints = 0,
                Position = Position.Goalkeeper,
                ClubId = 1,
            },
            new Player
            {
                Id = 28,
                Forename = "Derek",
                Surname = "Pender",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 1,
            },
            new Player
            {
                Id = 29,
                Forename = "Darragh",
                Surname = "Leahy",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 1,
            },
            new Player
            {
                Id = 30,
                Forename = "Rob",
                Surname = "Cornwall",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 1,
            },
            new Player
            {
                Id = 31,
                Forename = "Scott",
                Surname = "Allardice",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 1,
            },
            new Player
            {
                Id = 32,
                Forename = "Danny",
                Surname = "Mandroiu",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 1,
            },
            new Player
            {
                Id = 33,
                Forename = "Robbie",
                Surname = "McCourt",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 1,
            },
            new Player
            {
                Id = 34,
                Forename = "Dinny",
                Surname = "Corcoran",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 1,
            },
            new Player
            {
                Id = 35,
                Forename = "Keith",
                Surname = "Ward",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 1,
            },
            new Player
            {
                Id = 36,
                Forename = "Kevin",
                Surname = "Devaney",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 1,
            },
            new Player
            {
                Id = 37,
                Forename = "Daniel",
                Surname = "Grant",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 1,
            },
            new Player
            {
                Id = 38,
                Forename = "Conor",
                Surname = "Levingston",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 1,
            },
            new Player
            {
                Id = 39,
                Forename = "Sam",
                Surname = "Byrne",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 1,
            },
            #endregion

            #region Cork
            new Player
            {
                Id = 40,
                Forename = "Mark",
                Surname = "McNulty",
                TotalPoints = 0,
                Position = Position.Goalkeeper,
                ClubId = 2,
            },
            new Player
            {
                Id = 41,
                Forename = "Tadhg",
                Surname = "Ryan",
                TotalPoints = 0,
                Position = Position.Goalkeeper,
                ClubId = 2,
            },
            new Player
            {
                Id = 42,
                Forename = "Colm",
                Surname = "Horgan",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 2,
            },
            new Player
            {
                Id = 43,
                Forename = "Alan",
                Surname = "Bennett",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 2,
            },
            new Player
            {
                Id = 44,
                Forename = "Sean",
                Surname = "McLoughlin",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 2,
            },
            new Player
            {
                Id = 45,
                Forename = "Ronan",
                Surname = "Hurley",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 2,
            },
            new Player
            {
                Id = 46,
                Forename = "Shane",
                Surname = "Griffin",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 2,
            },
            new Player
            {
                Id = 47,
                Forename = "Gearoid",
                Surname = "Morrissey",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 2,
            },
            new Player
            {
                Id = 48,
                Forename = "Conor",
                Surname = "McCormack",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 2,
            },
            new Player
            {
                Id = 49,
                Forename = "Garry",
                Surname = "Buckley",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 2,
            },
            new Player
            {
                Id = 50,
                Forename = "Kevin",
                Surname = "O'Connor",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 2,
            },
            new Player
            {
                Id = 51,
                Forename = "Gary",
                Surname = "Boylan",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 2,
            },
            new Player
            {
                Id = 52,
                Forename = "Darragh",
                Surname = "Rainsford",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 2,
            },
            new Player
            {
                Id = 53,
                Forename = "Graham",
                Surname = "Cummins",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 2,
            },
            new Player
            {
                Id = 54,
                Forename = "Daire",
                Surname = "O'Connor",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 2,
            },
            new Player
            {
                Id = 55,
                Forename = "Karl",
                Surname = "Sheppard",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 2,
            },
            new Player
            {
                Id = 56,
                Forename = "James",
                Surname = "Tilley",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 2,
            },
            new Player
            {
                Id = 57,
                Forename = "Cian",
                Surname = "Murphy",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 2,
            },
            #endregion

            #region Derry City
                new Player
                {
                    Id = 1,
                    Forename = "Peter",
                    Surname = "Cherrie",
                    TotalPoints = 0,
                    Position = Position.Goalkeeper,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 2,
                    Forename = "Nathan",
                    Surname = "Gartside",
                    TotalPoints = 0,
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
                    TotalPoints = 0,
                    Position = Position.Defender,
                    ClubId = 3,
                },
                new Player
                {
                    Id = 5,
                    Forename = "Ciaran",
                    Surname = "Coll",
                    TotalPoints = 0,
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
                },
            #endregion

            #region Dundalk
            new Player
            {
                Id = 58,
                Forename = "Gary",
                Surname = "Rogers",
                TotalPoints = 0,
                Position = Position.Goalkeeper,
                ClubId = 4,
            },
            new Player
            {
                Id = 59,
                Forename = "Sean",
                Surname = "Gannon",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 4,
            },
            new Player
            {
                Id = 60,
                Forename = "Brian",
                Surname = "Gartland",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 4,
            },
            new Player
            {
                Id = 61,
                Forename = "Sean",
                Surname = "Hoare",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 4,
            },
            new Player
            {
                Id = 62,
                Forename = "Chris",
                Surname = "Shields",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 4,
            },
            new Player
            {
                Id = 63,
                Forename = "Jordan",
                Surname = "Flores",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 4,
            },
            new Player
            {
                Id = 64,
                Forename = "John",
                Surname = "Mountney",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 4,
            },
            new Player
            {
                Id = 65,
                Forename = "Patrick",
                Surname = "McEleney",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 4,
            },
            new Player
            {
                Id = 66,
                Forename = "Robbie",
                Surname = "Benson",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 4,
            },
            new Player
            {
                Id = 67,
                Forename = "Dean",
                Surname = "Jarvis",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 4,
            },
            new Player
            {
                Id = 68,
                Forename = "Georgie",
                Surname = "Kelly",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 4,
            },
            new Player
            {
                Id = 69,
                Forename = "Pat",
                Surname = "Hoban",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 4,
            },
            new Player
            {
                Id = 70,
                Forename = "Daniel",
                Surname = "Kelly",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 4,
            },
            new Player
            {
                Id = 71,
                Forename = "Jamie",
                Surname = "McGrath",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 4,
            },
            new Player
            {
                Id = 72,
                Forename = "Sean",
                Surname = "Murray",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 4,
            },
            new Player
            {
                Id = 73,
                Forename = "Dane",
                Surname = "Massey",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 4,
            },
    
            #endregion

            #region Harps
            new Player
            {
                Id = 74,
                Forename = "Ciaran",
                Surname = "Gallagher",
                TotalPoints = 0,
                Position = Position.Goalkeeper,
                ClubId = 5,
            },
            new Player
            {
                Id = 75,
                Forename = "Peter",
                Surname = "Burke",
                TotalPoints = 0,
                Position = Position.Goalkeeper,
                ClubId = 5,
            },
            new Player
            {
                Id = 76,
                Forename = "Sam",
                Surname = "Todd",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 5,
            },
            new Player
            {
                Id = 77,
                Forename = "Keith",
                Surname = "Cowan",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 5,
            },
            new Player
            {
                Id = 78,
                Forename = "Sam",
                Surname = "Ascroft",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 5,
            },
            new Player
            {
                Id = 79,
                Forename = "Daragh",
                Surname = "Elison",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 5,
            },
            new Player
            {
                Id = 80,
                Forename = "Niall",
                Surname = "Logue",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 5,
            },
            new Player
            {
                Id = 81,
                Forename = "Colm",
                Surname = "Deasy",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 5,
            },
            new Player
            {
                Id = 82,
                Forename = "Mark",
                Surname = "Coyle",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 5,
            },
            new Player
            {
                Id = 83,
                Forename = "Mikey",
                Surname = "Place",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 5,
            },
            new Player
            {
                Id = 84,
                Forename = "Rafael",
                Surname = "Cretaro",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 5,
            },
            new Player
            {
                Id = 85,
                Forename = "Niall",
                Surname = "McGinley",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 5,
            },
            new Player
            {
                Id = 86,
                Forename = "Tony",
                Surname = "McNamee",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 5,
            },
            new Player
            {
                Id = 87,
                Forename = "Mark",
                Surname = "Timlin",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 5,
            },
            new Player
            {
                Id = 88,
                Forename = "Gareth",
                Surname = "Harkin",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 5,
            },
            new Player
            {
                Id = 89,
                Forename = "Caolan",
                Surname = "McAleer",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 5,
            },
            new Player
            {
                Id = 90,
                Forename = "Nathan",
                Surname = "Boyle",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 5,
            },
            new Player
            {
                Id = 91,
                Forename = "Sean",
                Surname = "Boyd",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 5,
            },
            new Player
            {
                Id = 92,
                Forename = "Adam",
                Surname = "Duffy",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 5,
            },
            #endregion

            #region Shamrock Rovers
            new Player
            {
                Id = 93,
                Forename = "Alan",
                Surname = "Mannus",
                TotalPoints = 0,
                Position = Position.Goalkeeper,
                ClubId = 6,
            },
            new Player
            {
                Id = 94,
                Forename = "Leon",
                Surname = "Pohls",
                TotalPoints = 0,
                Position = Position.Goalkeeper,
                ClubId = 6,
            },
            new Player
            {
                Id = 95,
                Forename = "James",
                Surname = "Furlong",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 6,
            },
            new Player
            {
                Id = 96,
                Forename = "Sam",
                Surname = "Bone",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 6,
            },
            new Player
            {
                Id = 97,
                Forename = "Ethan",
                Surname = "Boyle",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 6,
            },
            new Player
            {
                Id = 98,
                Forename = "Roberto",
                Surname = "Lopes",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 6,
            },
            new Player
            {
                Id = 99,
                Forename = "Trevor",
                Surname = "Clarke",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 6,
            },
            new Player
            {
                Id = 100,
                Forename = "Aaron",
                Surname = "McEneff",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 6,
            },
            new Player
            {
                Id = 101,
                Forename = "Dylan",
                Surname = "Watts",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 6,
            },
            new Player
            {
                Id = 102,
                Forename = "Jack",
                Surname = "Byrne",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 6,
            },
            new Player
            {
                Id = 103,
                Forename = "Greg",
                Surname = "Bolger",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 6,
            },
            new Player
            {
                Id = 104,
                Forename = "Ronan",
                Surname = "Finn",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 6,
            },
            new Player
            {
                Id = 105,
                Forename = "Brandon",
                Surname = "Kavanagh",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 6,
            },
            new Player
            {
                Id = 106,
                Forename = "Aaron",
                Surname = "Greene",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 6,
            },
            new Player
            {
                Id = 107,
                Forename = "Dan",
                Surname = "Carr",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 6,
            },
            #endregion

            #region Sligo
            new Player
            {
                Id = 108,
                Forename = "Mitchell",
                Surname = "Beeney",
                TotalPoints = 0,
                Position = Position.Goalkeeper,
                ClubId = 7,
            },
            new Player
            {
                Id = 109,
                Forename = "Ed",
                Surname = "McGinty",
                TotalPoints = 0,
                Position = Position.Goalkeeper,
                ClubId = 7,
            },
            new Player
            {
                Id = 110,
                Forename = "Luke",
                Surname = "McNicholas",
                TotalPoints = 0,
                Position = Position.Goalkeeper,
                ClubId = 7,
            },
            new Player
            {
                Id = 111,
                Forename = "John",
                Surname = "Mahon",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 7,
            },
            new Player
            {
                Id = 112,
                Forename = "Kyle",
                Surname = "Callan-McFadden",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 7,
            },
            new Player
            {
                Id = 113,
                Forename = "Lewis",
                Surname = "Banks",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 7,
            },
            new Player
            {
                Id = 114,
                Forename = "Johnny",
                Surname = "Dunleavy",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 7,
            },
            new Player
            {
                Id = 115,
                Forename = "David",
                Surname = "Cawley",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 7,
            },
            new Player
            {
                Id = 116,
                Forename = "Jack",
                Surname = "Keaney",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 7,
            },
            new Player
            {
                Id = 117,
                Forename = "Daryl",
                Surname = "Fordyce",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 7,
            },
            new Player
            {
                Id = 118,
                Forename = "John",
                Surname = "Russell",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 7,
            },
            new Player
            {
                Id = 119,
                Forename = "Romeo",
                Surname = "Parkes",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 7,
            },
            new Player
            {
                Id = 120,
                Forename = "Ronan",
                Surname = "Coughlan",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 7,
            },
            new Player
            {
                Id = 121,
                Forename = "Ronan",
                Surname = "Murray",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 7,
            },
            #endregion

            #region Pats
            new Player
            {
                Id = 122,
                Forename = "Barry",
                Surname = "Murphy",
                TotalPoints = 0,
                Position = Position.Goalkeeper,
                ClubId = 8,
            },
            new Player
            {
                Id = 123,
                Forename = "Brendan",
                Surname = "Clarke",
                TotalPoints = 0,
                Position = Position.Goalkeeper,
                ClubId = 8,
            },
            new Player
            {
                Id = 124,
                Forename = "Kevin",
                Surname = "Toner",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 8,
            },
            new Player
            {
                Id = 125,
                Forename = "Simon",
                Surname = "Madden",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 8,
            },
            new Player
            {
                Id = 126,
                Forename = "David",
                Surname = "Webster",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 8,
            },
            new Player
            {
                Id = 127,
                Forename = "Liam",
                Surname = "Desmond",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 8,
            },
            new Player
            {
                Id = 128,
                Forename = "Darragh",
                Surname = "Markey",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 8,
            },
            new Player
            {
                Id = 129,
                Forename = "Chris",
                Surname = "Forrester",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 8,
            },
            new Player
            {
                Id = 130,
                Forename = "Rhys",
                Surname = "McCabe",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 8,
            },
            new Player
            {
                Id = 131,
                Forename = "Conor",
                Surname = "Clifford",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 8,
            },
            new Player
            {
                Id = 132,
                Forename = "Brandon",
                Surname = "Miele",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 8,
            },
            new Player
            {
                Id = 133,
                Forename = "James",
                Surname = "Doona",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 8,
            },
            new Player
            {
                Id = 134,
                Forename = "Michael",
                Surname = "Drennan",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 8,
            },
            new Player
            {
                Id = 135,
                Forename = "Darragh",
                Surname = "Markey",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 8,
            },
            new Player
            {
                Id = 136,
                Forename = "Dean",
                Surname = "Clarke",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 8,
            },
            new Player
            {
                Id = 137,
                Forename = "Gary",
                Surname = "Shaw",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 8,
            },
            #endregion

            #region UCD
            new Player
            {
                Id = 138,
                Forename = "Gavin",
                Surname = "Sheridan",
                TotalPoints = 0,
                Position = Position.Goalkeeper,
                ClubId = 9,
            },
            new Player
            {
                Id = 139,
                Forename = "Conor",
                Surname = "Kearns",
                TotalPoints = 0,
                Position = Position.Goalkeeper,
                ClubId = 9,
            },
            new Player
            {
                Id = 140,
                Forename = "Daniel",
                Surname = "Tobin",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 9,
            },
            new Player
            {
                Id = 141,
                Forename = "Evan",
                Surname = "Osam",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 9,
            },
            new Player
            {
                Id = 142,
                Forename = "Liam",
                Surname = "Scales",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 9,
            },
            new Player
            {
                Id = 143,
                Forename = "Josh",
                Surname = "Collins",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 9,
            },
            new Player
            {
                Id = 144,
                Forename = "Darragh",
                Surname = "Corcoran",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 9,
            },
            new Player
            {
                Id = 145,
                Forename = "Evan",
                Surname = "Farrell",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 9,
            },
            new Player
            {
                Id = 146,
                Forename = "Conor",
                Surname = "Crawley",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 9,
            },
            new Player
            {
                Id = 147,
                Forename = "Gary",
                Surname = "O'Neil",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 9,
            },
            new Player
            {
                Id = 148,
                Forename = "Timmy",
                Surname = "Molloy",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 9,
            },
            new Player
            {
                Id = 149,
                Forename = "Richie",
                Surname = "O'Farrell",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 9,
            },
            new Player
            {
                Id = 150,
                Forename = "Jack",
                Surname = "Ryan",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 9,
            },
            new Player
            {
                Id = 151,
                Forename = "Neil",
                Surname = "Farrugia",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 9,
            },
            new Player
            {
                Id = 152,
                Forename = "Yoyo",
                Surname = "Mahdy",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 9,
            },
            new Player
            {
                Id = 153,
                Forename = "Jason",
                Surname = "McClelland",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 9,
            },
            new Player
            {
                Id = 154,
                Forename = "Sean",
                Surname = "McDonald",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 9,
            },
            #endregion

            #region Waterford
            new Player
            {
                Id = 155,
                Forename = "Matthew",
                Surname = "Connor",
                TotalPoints = 0,
                Position = Position.Goalkeeper,
                ClubId = 10,
            },
            new Player
            {
                Id = 156,
                Forename = "Kenny",
                Surname = "Browne",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 10,
            },
            new Player
            {
                Id = 157,
                Forename = "John",
                Surname = "Martin",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 10,
            },
            new Player
            {
                Id = 158,
                Forename = "Dean",
                Surname = "Walsh",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 10,
            },
            new Player
            {
                Id = 159,
                Forename = "Rory",
                Surname = "Feely",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 10,
            },
            new Player
            {
                Id = 160,
                Forename = "Bastien",
                Surname = "Hery",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 10,
            },
            new Player
            {
                Id = 161,
                Forename = "Izzy",
                Surname = "Akinade",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 10,
            },
            new Player
            {
                Id = 162,
                Forename = "Paul",
                Surname = "Martin",
                TotalPoints = 0,
                Position = Position.Goalkeeper,
                ClubId = 10,
            },
            new Player
            {
                Id = 163,
                Forename = "Izzy",
                Surname = "Akinade",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 10,
            },
            new Player
            {
                Id = 164,
                Forename = "Shane",
                Surname = "Griffin",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 10,
            },
            new Player
            {
                Id = 165,
                Forename = "Zack",
                Surname = "Elbouzedi",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 10,
            },
            new Player
            {
                Id = 166,
                Forename = "Shane",
                Surname = "Duggan",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 10,
            },
            new Player
            {
                Id = 167,
                Forename = "Damien",
                Surname = "Delaney",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 10,
            },
            new Player
            {
                Id = 168,
                Forename = "Aaron",
                Surname = "Drinan",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 10,
            },
            new Player
            {
                Id = 169,
                Forename = "Maxim",
                Surname = "Kouogun",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 10,
            },
            new Player
            {
                Id = 170,
                Forename = "Georgie",
                Surname = "Poynton",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 10,
            },
            new Player
            {
                Id = 171,
                Forename = "Aaron",
                Surname = "Simpson",
                TotalPoints = 0,
                Position = Position.Defender,
                ClubId = 10,
            },
            new Player
            {
                Id = 172,
                Forename = "Karolis",
                Surname = "Chvedukas",
                TotalPoints = 0,
                Position = Position.Midfielder,
                ClubId = 10,
            },
            new Player
            {
                Id = 173,
                Forename = "Scott",
                Surname = "Twine",
                TotalPoints = 0,
                Position = Position.Forward,
                ClubId = 10,
            }
            #endregion
                    );

            #endregion

            #region Matches
            modelBuilder.Entity<Match>()
                .HasData(
            #region Fixture 1
                            new Match { Id = 1, HomeClub = "Waterford", AwayClub = "Shamrock Rovers", Date = new DateTime(2019, 2, 15, 20, 0, 0), FixtureId = 1 },
                            new Match { Id = 2, HomeClub = "St. Pats", AwayClub = "Cork City", Date = new DateTime(2019, 2, 12, 15, 45, 0), FixtureId = 1 },
                            new Match { Id = 3, HomeClub = "Dundalk", AwayClub = "Sligo Rovers", Date = new DateTime(2019, 2, 15, 19, 45, 0), FixtureId = 1 },
                            new Match { Id = 4, HomeClub = "Derry City", AwayClub = "U.C.D", Date = new DateTime(2019, 2, 15, 20, 19, 45), FixtureId = 1 },
                            new Match { Id = 5, HomeClub = "Bohemians", AwayClub = "Finn Harps", Date = new DateTime(2019, 2, 15, 20, 0, 0), FixtureId = 1 },
            #endregion
            #region Fixture 2
                            new Match { Id = 6, HomeClub = "Cork City", AwayClub = "Waterford", Date = new DateTime(2019, 2, 22, 20, 0, 0), FixtureId = 2 },
                            new Match { Id = 7, HomeClub = "Shamrock Rovers", AwayClub = "Derry City", Date = new DateTime(2019, 2, 22, 19, 45, 0), FixtureId = 2 },
                            new Match { Id = 8, HomeClub = "Finn Harps", AwayClub = "Dundalk", Date = new DateTime(2019, 2, 22, 19, 45, 0), FixtureId = 2 },
                            new Match { Id = 9, HomeClub = "U.C.D", AwayClub = "Bohemians", Date = new DateTime(2019, 2, 22, 20, 19, 45), FixtureId = 2 },
                            new Match { Id = 10, HomeClub = "Sligo Rovers", AwayClub = "St. Pats", Date = new DateTime(2019, 2, 22, 20, 0, 0), FixtureId = 2 },
            #endregion
            #region Fixture 3
                            new Match { Id = 11, HomeClub = "Bohemians", AwayClub = "Shamrock Rovers", Date = new DateTime(2019, 2, 25, 20, 0, 0), FixtureId = 3 },
                            new Match { Id = 12, HomeClub = "Derry City", AwayClub = "Waterford", Date = new DateTime(2019, 2, 25, 19, 45, 0), FixtureId = 3 },
                            new Match { Id = 13, HomeClub = "Dundalk", AwayClub = "U.C.D", Date = new DateTime(2019, 2, 25, 19, 45, 0), FixtureId = 3 },
                            new Match { Id = 14, HomeClub = "St. Pats", AwayClub = "Finn Harps", Date = new DateTime(2019, 2, 25, 20, 19, 45), FixtureId = 3 },
                            new Match { Id = 15, HomeClub = "Sligo Rovers", AwayClub = "Cork City", Date = new DateTime(2019, 2, 25, 20, 0, 0), FixtureId = 3 },
            #endregion
            #region Fixture 4
                            new Match { Id = 16, HomeClub = "Cork City", AwayClub = "Derry City", Date = new DateTime(2019, 3, 1, 20, 0, 0), FixtureId = 4 },
                            new Match { Id = 17, HomeClub = "U.C.D", AwayClub = "St. Pats", Date = new DateTime(2019, 3, 1, 19, 45, 0), FixtureId = 4 },
                            new Match { Id = 18, HomeClub = "Waterford", AwayClub = "Bohemians", Date = new DateTime(2019, 3, 1, 19, 45, 0), FixtureId = 4 },
                            new Match { Id = 19, HomeClub = "Finn Harps", AwayClub = "Sligo Rovers", Date = new DateTime(2019, 3, 1, 20, 19, 45), FixtureId = 4 },
                            new Match { Id = 20, HomeClub = "Shamrock Rovers", AwayClub = "Dundalk", Date = new DateTime(2019, 3, 1, 20, 0, 0), FixtureId = 4 },
                            new Match { Id = 21, HomeClub = "Finn Harps", AwayClub = "Shamrock Rovers", Date = new DateTime(2019, 3, 4, 20, 0, 0), FixtureId = 4 },
            #endregion
            #region Fixture 5
                            new Match { Id = 22, HomeClub = "Bohemians", AwayClub = "Derry City", Date = new DateTime(2019, 3, 8, 20, 0, 0), FixtureId = 5 },
                            new Match { Id = 23, HomeClub = "Dundalk", AwayClub = "Waterford", Date = new DateTime(2019, 3, 8, 19, 45, 0), FixtureId = 5 },
                            new Match { Id = 24, HomeClub = "St. Pats", AwayClub = "Shamrock Rovers", Date = new DateTime(2019, 3, 8, 19, 45, 0), FixtureId = 5 },
                            new Match { Id = 25, HomeClub = "Finn Harps", AwayClub = "Cork", Date = new DateTime(2019, 3, 8, 20, 19, 45), FixtureId = 5 },
                            new Match { Id = 26, HomeClub = "Sligo Rovers", AwayClub = "U.C.D", Date = new DateTime(2019, 3, 8, 20, 0, 0), FixtureId = 5 },
            #endregion
            #region Fixture 6
                            new Match { Id = 27, HomeClub = "Cork City", AwayClub = "Bohemians", Date = new DateTime(2019, 3, 15, 20, 0, 0), FixtureId = 6 },
                            new Match { Id = 28, HomeClub = "Derry City", AwayClub = "Dundalk", Date = new DateTime(2019, 3, 15, 19, 45, 0), FixtureId = 6 },
                            new Match { Id = 29, HomeClub = "U.C.D", AwayClub = "Finn Harps", Date = new DateTime(2019, 3, 15, 19, 45, 0), FixtureId = 6 },
                            new Match { Id = 30, HomeClub = "Waterford", AwayClub = "St.Pats", Date = new DateTime(2019, 3, 15, 20, 19, 45), FixtureId = 6 },
                            new Match { Id = 31, HomeClub = "Shamrock Rovers", AwayClub = "Sligo Rovers", Date = new DateTime(2019, 3, 15, 20, 0, 0), FixtureId = 6 },
            #endregion
            #region Fixture 7
                            new Match { Id = 32, HomeClub = "Finn Harps", AwayClub = "Shamrock Rovers", Date = new DateTime(2019, 3, 22, 20, 0, 0), FixtureId = 7 },
                            new Match { Id = 33, HomeClub = "Dundalk", AwayClub = "Bohemians", Date = new DateTime(2019, 4, 15, 19, 45, 0), FixtureId = 7 },
                            new Match { Id = 34, HomeClub = "St. Pats", AwayClub = "Derry City", Date = new DateTime(2019, 4, 15, 19, 45, 0), FixtureId = 7 },
                            new Match { Id = 35, HomeClub = "U.C.D", AwayClub = "Cork City", Date = new DateTime(2019, 4, 15, 20, 19, 45), FixtureId = 7 },
                            new Match { Id = 36, HomeClub = "Sligo Rovers", AwayClub = "Waterford", Date = new DateTime(2019, 4, 15, 20, 0, 0), FixtureId = 7 },
            #endregion
            #region Fixture 8
                            new Match { Id = 37, HomeClub = "Bohemians", AwayClub = "St. Pats", Date = new DateTime(2019, 3, 29, 20, 0, 0), FixtureId = 8 },
                            new Match { Id = 38, HomeClub = "Derry City", AwayClub = "Sligo Rovers", Date = new DateTime(2019, 3, 29, 19, 45, 0), FixtureId = 8 },
                            new Match { Id = 39, HomeClub = "Dundalk", AwayClub = "Cork City", Date = new DateTime(2019, 3, 29, 19, 45, 0), FixtureId = 8 },
                            new Match { Id = 40, HomeClub = "Waterford", AwayClub = "Finn Harps", Date = new DateTime(2019, 3, 29, 20, 19, 45), FixtureId = 8 },
                            new Match { Id = 41, HomeClub = "Shamrock Rovers", AwayClub = "U.C.D", Date = new DateTime(2019, 3, 29, 20, 0, 0), FixtureId = 8 },
            #endregion
            #region Fixture 9
                            new Match { Id = 42, HomeClub = "Cork City", AwayClub = "Shamrock Rovers", Date = new DateTime(2019, 4, 5, 20, 0, 0), FixtureId = 9 },
                            new Match { Id = 43, HomeClub = "St. Pats", AwayClub = "Dundalk", Date = new DateTime(2019, 4, 5, 19, 45, 0), FixtureId = 9 },
                            new Match { Id = 44, HomeClub = "U.C.D", AwayClub = "Waterford", Date = new DateTime(2019, 4, 5, 19, 45, 0), FixtureId = 9 },
                            new Match { Id = 45, HomeClub = "Finn Harps", AwayClub = "Derry City", Date = new DateTime(2019, 4, 5, 20, 19, 45), FixtureId = 9 },
                            new Match { Id = 46, HomeClub = "Sligo Rovers", AwayClub = "Bohemians", Date = new DateTime(2019, 4, 5, 20, 0, 0), FixtureId = 9 },
            #endregion
            #region Fixture 10
                            new Match { Id = 47, HomeClub = "Cork City", AwayClub = "St. Pats", Date = new DateTime(2019, 4, 12, 20, 0, 0), FixtureId = 10 },
                            new Match { Id = 48, HomeClub = "U.C.D", AwayClub = "Derry City", Date = new DateTime(2019, 4, 12, 19, 45, 0), FixtureId = 10 },
                            new Match { Id = 49, HomeClub = "Sligo Rovers", AwayClub = "Dundalk", Date = new DateTime(2019, 4, 12, 19, 45, 0), FixtureId = 10 },
                            new Match { Id = 50, HomeClub = "Finn Harps", AwayClub = "Bohemians", Date = new DateTime(2019, 4, 12, 20, 19, 45), FixtureId = 10 },
                            new Match { Id = 51, HomeClub = "Shamrock Rovers", AwayClub = "Waterford", Date = new DateTime(2019, 4, 12, 20, 0, 0), FixtureId = 10 },
            #endregion
            #region Fixture 11
                            new Match { Id = 52, HomeClub = "Dundalk", AwayClub = "Bohemians", Date = new DateTime(2019, 4, 15, 20, 0, 0), FixtureId = 11 },
                            new Match { Id = 53, HomeClub = "St. Pats", AwayClub = "Derry City", Date = new DateTime(2019, 4, 15, 19, 45, 0), FixtureId = 11 },
                            new Match { Id = 54, HomeClub = "U.C.D", AwayClub = "Cork City", Date = new DateTime(2019, 4, 15, 19, 45, 0), FixtureId = 11 },
                            new Match { Id = 55, HomeClub = "Sligo Rovers", AwayClub = "Waterford", Date = new DateTime(2019, 4, 15, 20, 19, 45), FixtureId = 11 },
            #endregion
            #region Fixture 12
                            new Match { Id = 56, HomeClub = "Bohemians", AwayClub = "U.C.D", Date = new DateTime(2019, 4, 19, 20, 0, 0), FixtureId = 12 },
                            new Match { Id = 57, HomeClub = "Derry City", AwayClub = "Shamrock Rovers", Date = new DateTime(2019, 4, 19, 19, 45, 0), FixtureId = 12 },
                            new Match { Id = 58, HomeClub = "Dundalk", AwayClub = "Finn Harps", Date = new DateTime(2019, 4, 19, 19, 45, 0), FixtureId = 12 },
                            new Match { Id = 59, HomeClub = "St. Pats", AwayClub = "Sligo Rovers", Date = new DateTime(2019, 4, 19, 20, 19, 45), FixtureId = 12 },
                            new Match { Id = 60, HomeClub = "Waterford", AwayClub = "Cork City", Date = new DateTime(2019, 4, 19, 20, 0, 0), FixtureId = 12 },
            #endregion
            #region Fixture 13
                            new Match { Id = 61, HomeClub = "U.C.D", AwayClub = "Dundalk", Date = new DateTime(2019, 4, 22, 20, 0, 0), FixtureId = 13 },
                            new Match { Id = 62, HomeClub = "Waterford", AwayClub = "Derry City", Date = new DateTime(2019, 4, 22, 19, 45, 0), FixtureId = 13 },
                            new Match { Id = 63, HomeClub = "Cork City", AwayClub = "Sligo Rovers", Date = new DateTime(2019, 4, 22, 19, 45, 0), FixtureId = 13 },
                            new Match { Id = 64, HomeClub = "Finn Harps", AwayClub = "St. Pats", Date = new DateTime(2019, 4, 22, 20, 19, 45), FixtureId = 13 },
                            new Match { Id = 65, HomeClub = "Shamrock Rovers", AwayClub = "Bohemians", Date = new DateTime(2019, 4, 23, 20, 0, 0), FixtureId = 13 },
            #endregion
            #region Fixture 14
                            new Match { Id = 66, HomeClub = "Bohemians", AwayClub = "Waterford", Date = new DateTime(2019, 4, 26, 20, 0, 0), FixtureId = 14 },
                            new Match { Id = 67, HomeClub = "Derry City", AwayClub = "Cork City", Date = new DateTime(2019, 4, 26, 19, 45, 0), FixtureId = 14 },
                            new Match { Id = 68, HomeClub = "St. Pats", AwayClub = "U.C.D", Date = new DateTime(2019, 4, 26, 19, 45, 0), FixtureId = 14 },
                            new Match { Id = 69, HomeClub = "Sligo Rovers", AwayClub = "Finn Harps", Date = new DateTime(2019, 4, 26, 20, 19, 45), FixtureId = 14 },
                            new Match { Id = 70, HomeClub = "Dundalk", AwayClub = "Shamrock Rovers", Date = new DateTime(2019, 4, 26, 20, 0, 0), FixtureId = 14 },
            #endregion
            #region Fixture 15
                            new Match { Id = 71, HomeClub = "Cork City", AwayClub = "Finn Harps", Date = new DateTime(2019, 4, 29, 20, 0, 0), FixtureId = 15 },
                            new Match { Id = 72, HomeClub = "Derry City", AwayClub = "Bohemians", Date = new DateTime(2019, 4, 29, 19, 45, 0), FixtureId = 15 },
                            new Match { Id = 73, HomeClub = "U.C.D", AwayClub = "Sligo Rovers", Date = new DateTime(2019, 4, 29, 19, 45, 0), FixtureId = 15 },
                            new Match { Id = 74, HomeClub = "Waterford", AwayClub = "Dundalk", Date = new DateTime(2019, 4, 29, 20, 19, 45), FixtureId = 15 },
                            new Match { Id = 75, HomeClub = "Shamrock Rovers", AwayClub = "St. Pats", Date = new DateTime(2019, 4, 29, 20, 0, 0), FixtureId = 15 },
            #endregion
            #region Fixture 16
                            new Match { Id = 76, HomeClub = "Bohemians", AwayClub = "Cork City", Date = new DateTime(2019, 5, 3, 20, 0, 0), FixtureId = 16 },
                            new Match { Id = 77, HomeClub = "Dundalk", AwayClub = "Derry City", Date = new DateTime(2019, 5, 3, 19, 45, 0), FixtureId = 16 },
                            new Match { Id = 78, HomeClub = "St. Pats", AwayClub = "Waterford", Date = new DateTime(2019, 5, 3, 19, 45, 0), FixtureId = 16 },
                            new Match { Id = 79, HomeClub = "Finn Harps", AwayClub = "U.C.D", Date = new DateTime(2019, 5, 3, 20, 19, 45), FixtureId = 16 },
                            new Match { Id = 80, HomeClub = "Sligo Rovers", AwayClub = "Shamrock Rovers", Date = new DateTime(2019, 5, 3, 20, 0, 0), FixtureId = 16 },
            #endregion            
            #region Fixture 17
                            new Match { Id = 81, HomeClub = "Shamrock Rovers", AwayClub = "Finn Harps", Date = new DateTime(2019, 3, 4, 20, 0, 0), FixtureId = 17 },
                            new Match { Id = 82, HomeClub = "Bohemians", AwayClub = "Dundalk", Date = new DateTime(2019, 5, 10, 19, 45, 0), FixtureId = 17 },
                            new Match { Id = 83, HomeClub = "Cork City", AwayClub = "U.C.D", Date = new DateTime(2019, 5, 10, 19, 45, 0), FixtureId = 17 },
                            new Match { Id = 84, HomeClub = "Derry City", AwayClub = "St. Pats", Date = new DateTime(2019, 5, 10, 20, 19, 45), FixtureId = 17 },
                            new Match { Id = 85, HomeClub = "Waterford", AwayClub = "Sligo Rovers", Date = new DateTime(2019, 5, 10, 20, 0, 0), FixtureId = 17 },
            #endregion
            #region Fixture 18
                            new Match { Id = 86, HomeClub = "Cork City", AwayClub = "Dundalk", Date = new DateTime(2019, 5, 17, 20, 0, 0), FixtureId = 18 },
                            new Match { Id = 87, HomeClub = "St. Pats", AwayClub = "Bohemians", Date = new DateTime(2019, 5, 17, 19, 45, 0), FixtureId = 18 },
                            new Match { Id = 88, HomeClub = "U.C.D", AwayClub = "Shamrock Rovers", Date = new DateTime(2019, 5, 17, 19, 45, 0), FixtureId = 18 },
                            new Match { Id = 89, HomeClub = "Finn Harps", AwayClub = "Waterford", Date = new DateTime(2019, 5, 17, 20, 19, 45), FixtureId = 18 },
                            new Match { Id = 90, HomeClub = "Sligo Rovers", AwayClub = "Derry City", Date = new DateTime(2019, 5, 18, 20, 0, 0), FixtureId = 18 },
            #endregion
            #region Fixture 19
                            new Match { Id = 91, HomeClub = "Dundlk", AwayClub = "Bohemians", Date = new DateTime(2019, 5, 20, 20, 0, 0), FixtureId = 19 },
                            new Match { Id = 92, HomeClub = "U.C.D", AwayClub = "Cork City", Date = new DateTime(2019, 5, 20, 19, 45, 0), FixtureId = 19 },
                            new Match { Id = 93, HomeClub = "Finn Harps", AwayClub = "Shamrock Rovers", Date = new DateTime(2019, 5, 20, 19, 45, 0), FixtureId = 19 },
                            new Match { Id = 94, HomeClub = "Sligo Rovers", AwayClub = "Waterford", Date = new DateTime(2019, 5, 20, 20, 19, 45), FixtureId = 19 },
            #endregion
            #region Fixture 20
                            new Match { Id = 96, HomeClub = "Bohemians", AwayClub = "Sligo Rovers", Date = new DateTime(2019, 5, 24, 20, 0, 0), FixtureId = 20 },
                            new Match { Id = 97, HomeClub = "Derry City", AwayClub = "Finn Harps", Date = new DateTime(2019, 5, 24, 19, 45, 0), FixtureId = 20 },
                            new Match { Id = 98, HomeClub = "Dundalk", AwayClub = "St. Pats", Date = new DateTime(2019, 5, 24, 19, 45, 0), FixtureId = 20 },
                            new Match { Id = 99, HomeClub = "Waterford", AwayClub = "U.C.D", Date = new DateTime(2019, 5, 24, 20, 19, 45), FixtureId = 20 },
                            new Match { Id = 100, HomeClub = "Shamrock Rovers", AwayClub = "Cork City", Date = new DateTime(2019, 5, 24, 20, 0, 0), FixtureId = 20 }
            #endregion
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

            #region Users
            modelBuilder.Entity<User>()
                .HasData(
                new User { Id = -1, ForeName ="System", SurName = "Administrator", Password = "LOISystemAdmin", Role = Role.Administrator, UserName = "administrator"  }
                );
            #endregion
        }
    }
}
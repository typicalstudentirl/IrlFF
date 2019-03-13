using IrlFF.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;

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
                .UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = IrlFF; Trusted_Connection = True; ConnectRetryCount = 0;")
                .UseLoggerFactory(GetLoggerFactory());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamPlayer>()
                .HasKey(tp => new { tp.TeamId, tp.PlayerId });

            modelBuilder.Entity<Fixture>()
                .HasData(new Fixture { Id = 1 } );
                

            modelBuilder.Entity<Match>()
                .HasData(
                            new Match { Id = 1, HomeClub = "Waterford", AwayClub = "Shamrock Rovers", Date = new DateTime(2019, 2, 15, 20, 0, 0), Location = "Waterford Regional Sports Centre", FixtureId = 1 },
                            new Match { Id = 2, HomeClub = "St. Pats", AwayClub = "Cork City", Date = new DateTime(2019, 2, 12, 19, 45, 0), Location = "Richmond Park", FixtureId = 1 },
                            new Match { Id = 3, HomeClub = "Dundalk", AwayClub = "Sligo Rovers", Date = new DateTime(2019, 2, 12, 19, 45, 0), Location = "Oriel Park", FixtureId = 1 },
                            new Match { Id = 4, HomeClub = "Derry City", AwayClub = "U.C.D", Date = new DateTime(2019, 2, 12, 20, 19, 45), Location = "The Brandywell Stadium", FixtureId = 1 },
                            new Match { Id = 5, HomeClub = "Bohemians", AwayClub = "Finn Harps", Date = new DateTime(2019, 2, 12, 20, 0, 0), Location = "Dalymount Park", FixtureId = 1 }
                );
        }

        private ILoggerFactory GetLoggerFactory()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(builder =>
                builder.AddConsole()
                    .AddFilter(DbLoggerCategory.Database.Command.Name,
                        LogLevel.Information));
            return serviceCollection.BuildServiceProvider()
                .GetService<ILoggerFactory>();
        }
    }
}
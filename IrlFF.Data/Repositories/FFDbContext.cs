using IrlFF.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace IrlFF.Data.Repositories
{
    class FFDbContext : DbContext
    {
        public DbSet<Player> Player { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<TeamPlayer> TeamPlayer { get; set; }
        public DbSet<Club> Club { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = IrlFF; Trusted_Connection = True; ConnectRetryCount = 0;")
                .UseLoggerFactory(GetLoggerFactory());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>()
                .Property(t => t.TotalPoints)
                .HasDefaultValue(0);

            modelBuilder.Entity<TeamPlayer>()
                .HasKey(tp => new { tp.TeamId, tp.PlayerId });
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
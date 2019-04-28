using System;
using Microsoft.EntityFrameworkCore;

namespace IrlFF.Data.Repositories
{
    public static class FFDbContextFactory
    {

        public static Func<DbContextOptionsBuilder> Builder =>
            () => new DbContextOptionsBuilder<FFDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString());


        public static FFDbContext CreateTestCtx()
        {
            return new FFDbContext(new DbContextOptionsBuilder<FFDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options
            );
        }

        public static FFDbContext CreateCtx()
        {
            return new FFDbContext(new DbContextOptionsBuilder<FFDbContext>()
                .UseSqlServer(@"Server=tcp:irlff.database.windows.net,1433;Initial Catalog=IrlFFDb;Persist Security Info=False;User ID=s6irladmin;Password=5Maxin2e;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=200;")
                // .UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = IrlFF; Trusted_Connection = True; ConnectRetryCount = 0;")
               .Options
               );
        }
    }
}
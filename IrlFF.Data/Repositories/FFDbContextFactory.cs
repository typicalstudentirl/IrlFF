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
                 .UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = IrlFF; Trusted_Connection = True; ConnectRetryCount = 0;")
               .Options
               );
        }
    }
}

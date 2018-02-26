using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AmmStew.EntityFrameworkCore
{
    public static class AmmStewDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AmmStewDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AmmStewDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

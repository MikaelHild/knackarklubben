using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AmmStew.Configuration;
using AmmStew.Web;

namespace AmmStew.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AmmStewDbContextFactory : IDesignTimeDbContextFactory<AmmStewDbContext>
    {
        public AmmStewDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AmmStewDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AmmStewDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AmmStewConsts.ConnectionStringName));

            return new AmmStewDbContext(builder.Options);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MMHDemo.Configuration;
using MMHDemo.Web;

namespace MMHDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MMHDemoDbContextFactory : IDesignTimeDbContextFactory<MMHDemoDbContext>
    {
        public MMHDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MMHDemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder(), addUserSecrets: true);

            MMHDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MMHDemoConsts.ConnectionStringName));

            return new MMHDemoDbContext(builder.Options);
        }
    }
}
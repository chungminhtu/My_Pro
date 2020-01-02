using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MMHDemo.EntityFrameworkCore
{
    public static class MMHDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MMHDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MMHDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
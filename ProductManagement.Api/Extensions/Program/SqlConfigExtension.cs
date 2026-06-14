using Microsoft.EntityFrameworkCore;
using ProductManagement.Infrastructure.Contexts;
using ProductManagement.Infrastructure.Seeders;

namespace ProductManagement.Api.Extensions.Program
{
    public static class SqlConfigExtension
    {
        public static void AddSqlConfigs(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<ProductManagementDbContext>(options =>
            {
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("ProductManagementDbContext"),
                    x => x.MigrationsAssembly("ProductManagement.Infrastructure"));
                options.UseSeeding(UseDatabaseSeeder);
                options.UseAsyncSeeding(async (x, y, z) => await UseDatabaseSeederAsync(x, y, z));
            });

        }

        private static async Task UseDatabaseSeederAsync(
            DbContext context,
            bool hasSchema,
            CancellationToken cancellationToken)
        {
            var dbContext = (ProductManagementDbContext)context;

            // Seed roles with GUIDs
            await ProductTypeSeeder.RunAsync(dbContext);

            await dbContext.SaveChangesAsync();
        }


        private static void UseDatabaseSeeder(
            DbContext context,
            bool hasSchema)
        {
            var dbContext = (ProductManagementDbContext)context;

            // Seed roles with GUIDs
            ProductTypeSeeder.Run(dbContext);

            dbContext.SaveChanges();
        }
    }
}

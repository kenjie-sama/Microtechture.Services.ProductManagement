using Microsoft.EntityFrameworkCore;
using ProductManagement.Infrastructure.Contexts;
using ProductManagement.Infrastructure.Seeders;

namespace ProductManagement.Api.Extensions.Program
{
    public static class DatabaseSeederExtension
    {
        public static async Task UseDatabaseSeederAsync(
            DbContext context, 
            bool hasSchema, 
            CancellationToken cancellationToken)
        {
            var dbContext = (ProductManagementDbContext)context;

            // Seed roles with GUIDs
            await ProductTypeSeeder.Run(dbContext);

            await dbContext.SaveChangesAsync();
        }
    }
}

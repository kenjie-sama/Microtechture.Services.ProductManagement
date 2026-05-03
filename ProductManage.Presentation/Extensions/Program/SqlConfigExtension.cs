using Microsoft.EntityFrameworkCore;
using ProductManagement.Infrastructure.Contexts;

namespace ProductManage.Presentation.Extensions.Program
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
            });

        }
    }
}

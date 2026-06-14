using ProductManagement.Application.Services.Implementations;
using ProductManagement.Application.Services.Interfaces;
using ProductManagement.Domain.Interfaces.Repositories;
using ProductManagement.Infrastructure.Repositories;

namespace ProductManagement.Api.Extensions.Program
{
    public static class CustomServicesExtension
    {
        public static void AddCustomServicesConfigs(this WebApplicationBuilder builder)
        {
            AddServices(builder);
            AddRepositories(builder);
        }

        private static void AddServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IProductService, ProductService>();
        }

        private static void AddRepositories(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IProductsRepository, ProductsRepository>();
        }
    }
}

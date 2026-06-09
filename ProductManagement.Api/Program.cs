using ProductManagement.Api.Extensions.App;
using ProductManagement.Api.Extensions.Program;

namespace ProductManagement.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.AddSqlConfigs();
            builder.AddCustomServicesConfigs();
            builder.AddEndpointConfigs();

            var app = builder.Build();
            app.AddMiddlewareConfigs();
            app.Run();
        }
    }
}

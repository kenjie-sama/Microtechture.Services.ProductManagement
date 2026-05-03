using ProductManage.Api.Extensions.App;
using ProductManage.Api.Extensions.Program;

namespace ProductManage.Api
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


using ProductManage.Presentation.Extensions.App;
using ProductManage.Presentation.Extensions.Program;

namespace ProductManage.Presentation
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

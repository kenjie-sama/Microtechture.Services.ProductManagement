using Scalar.AspNetCore;

namespace ProductManagement.Api.Extensions.App
{
    public static class MiddlewareConfigExtension
    {
        public static void AddMiddlewareConfigs(this WebApplication app)
        {

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
        }
    }
}

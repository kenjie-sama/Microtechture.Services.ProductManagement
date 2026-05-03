namespace ProductManage.Presentation.Extensions.App
{
    public static class MiddlewareConfigExtension
    {
        public static void AddMiddlewareConfigs(this WebApplication app)
        {

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
        }
    }
}

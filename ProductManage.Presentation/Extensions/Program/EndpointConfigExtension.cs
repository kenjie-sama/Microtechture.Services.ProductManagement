namespace ProductManage.Presentation.Extensions.Program
{
    public static class EndpointConfigExtension
    {
        public static void AddEndpointConfigs(this WebApplicationBuilder builder)
        {

            builder.Services.AddControllers();
            builder.Services.AddOpenApi();
        }
    }
}

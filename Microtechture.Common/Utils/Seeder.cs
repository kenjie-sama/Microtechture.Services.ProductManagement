using Microsoft.EntityFrameworkCore;

namespace Microtechture.Common.Utils
{
    public abstract class Seeder<TDbContext> : DbContext where TDbContext : DbContext
    {
        protected readonly TDbContext dbContext;
        protected abstract Task Init();
        public static async Task Run(TDbContext dbContext)
        {
            var seeder = (Seeder<TDbContext>)Activator.CreateInstance(typeof(Seeder<TDbContext>), dbContext) ?? throw new InvalidOperationException("Failed to create seeder instance");
            await seeder.Init();
        }
    }
}

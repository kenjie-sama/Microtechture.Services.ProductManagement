using Microsoft.EntityFrameworkCore;
using ProductManagement.Domain.Models.Entities;
using ProductManagement.Domain.Models.Entities.CodesTable;

namespace ProductManagement.Infrastructure.Contexts
{
    public class ProductManagementDbContext(DbContextOptions<ProductManagementDbContext> options) : DbContext(options)
    {
        #region Entities
        public virtual DbSet<Product> Products { get; set; }
        #endregion

        #region CodesTable
        public virtual DbSet<ProductType> ProductTypes { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(x => x.Price)
                      .HasPrecision(18, 2);

                entity.ToTable("Products", b => b.IsTemporal(
                    t =>
                    {
                        t.UseHistoryTable("ProductsHistory");
                        t.HasPeriodStart("ValidFrom");
                        t.HasPeriodEnd("ValidTo");
                    }));
            }); 
        }
    }
}

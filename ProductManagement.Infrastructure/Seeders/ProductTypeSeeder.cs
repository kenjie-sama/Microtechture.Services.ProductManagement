using Microsoft.EntityFrameworkCore;
using Microtechture.Common.Utils;
using ProductManagement.Domain.Helpers.CodesTable;
using ProductManagement.Domain.Models.Entities.CodesTable;
using ProductManagement.Infrastructure.Contexts;
using Types = ProductManagement.Domain.Enums.CodesTable;

namespace ProductManagement.Infrastructure.Seeders
{
    public abstract class ProductTypeSeeder : Seeder<ProductManagementDbContext>
    {
        protected override async Task Init()
        {
            var productTypes = new List<ProductType>
            {
                ProductTypeHelper.Create(Types.ProductType.Software, "Softwares and Applications"),
                ProductTypeHelper.Create(Types.ProductType.Hardware, "Hardwares"),
                ProductTypeHelper.Create(Types.ProductType.Plasticware, "Plasticware"),
                ProductTypeHelper.Create(Types.ProductType.Chemical, "Chemicals / Toxins"),
                ProductTypeHelper.Create(Types.ProductType.Food, "Food Items"),
                ProductTypeHelper.Create(Types.ProductType.Medications, "Oral Medications"),
                ProductTypeHelper.Create(Types.ProductType.Beverage, "Drinks and Beverages / Liquid Items"),
                ProductTypeHelper.Create(Types.ProductType.Electronics, "Electronics / Appliances"),
                ProductTypeHelper.Create(Types.ProductType.Others, "Others / Unspecified")
            };

            await dbContext.ProductTypes.AddRangeAsync(productTypes);
        }
    }
}

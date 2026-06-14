using Microsoft.EntityFrameworkCore;
using Microtechture.Common.Utils;
using ProductManagement.Domain.Helpers.CodesTable;
using ProductManagement.Domain.Models.Entities.CodesTable;
using ProductManagement.Infrastructure.Contexts;
using Types = ProductManagement.Domain.Enums.CodesTable;

namespace ProductManagement.Infrastructure.Seeders
{
    public class ProductTypeSeeder
    {
        private static readonly IEnumerable<ProductType> data = new List<ProductType>
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

        public static async Task RunAsync(ProductManagementDbContext dbContext)
        {
            var existings = dbContext.ProductTypes.ToList();
            var unmatchData = Linq.TakeSourceUnmatch(data, existings, d => d.Code).ToList();

            if (!unmatchData.Any())
            {
                return;
            }

            await dbContext.AddRangeAsync(unmatchData);
        }

        public static void Run(ProductManagementDbContext dbContext)
        {
            var existings = dbContext.ProductTypes.ToList();
            var unmatchData = Linq.TakeSourceUnmatch(data, existings, d => d.Code).ToList();

            if (!unmatchData.Any())
            {
                return;
            }

            dbContext.AddRange(unmatchData);
        }
    }
}

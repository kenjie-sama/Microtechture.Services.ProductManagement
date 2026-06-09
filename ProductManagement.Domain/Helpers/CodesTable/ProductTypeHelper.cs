using Microtechture.Common.Constants;
using Microtechture.Common.Utils;
using CT = ProductManagement.Domain.Models.Entities.CodesTable;
using Types = ProductManagement.Domain.Enums.CodesTable;

namespace ProductManagement.Domain.Helpers.CodesTable
{
    public class ProductTypeHelper
    {
        public static CT.ProductType Create(
            Types.ProductType typeCode,
            string description,
            Guid? id = null,
            string creator = StaticDetails.DOMAIN_SYSTEM,
            int priority = StaticDetails.PRIORITY_DEFAULT,
            string? title = null)
        { 
            return new CT.ProductType()
            {
                Id = id ?? Guid.NewGuid(),
                Code = ((short)typeCode).ToString(),
                Title = Security.Sanitize(title ?? typeCode.ToString()),
                Description = Security.Sanitize(description),
                Priority = 0,
                CreatedBy = creator,
                DateTimeCreated = DateTime.Now,
                ModifiedBy = creator,
                DateTimeModified = DateTime.Now,
                IsActive = true,
            };
        }
    }
}

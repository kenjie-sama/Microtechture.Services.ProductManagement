using Microtechture.Common.Utils;
using ProductManagement.Application.Models.Dtos;
using ProductManagement.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Application.Mappers
{
    public static class ProductMapper
    {
        /// <summary>
        /// Map Product to ProductDetailDto
        /// </summary>
        /// <param name="product"></param>
        /// <returns>
        /// Id = actual Guid value of the product
        /// Name = decoded string value of the product's name
        /// Description = decoded string value of the product's description
        /// Price = absolute value of the product's price converted to decimal
        /// </returns>
        public static ProductDetailDto ToProductDetail(Product product)
        {
            return new ProductDetailDto
            {
                Id = product.Id,
                Name = Security.DecodeString(product.Name),
                Description = Security.DecodeString(product.Description),
                Price = (decimal) Math.Abs(product.Price)
            };
        }


        public static Product ToProduct(ProductCreateDto product)
        {
            return new Product(
                Security.Sanitize(product.Name),
                Security.Sanitize(product.Description),
                (double) Math.Abs(product.Price),
                product.TypeId,
                product.CreatedBy
            );
        }
    }
}

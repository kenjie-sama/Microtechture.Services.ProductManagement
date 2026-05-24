using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Application.Models.Dtos
{
    public record ProductDetailDto
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public decimal Price { get; init; }
    }
}

using ProductManagement.Domain.Enums.CodesTable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductManagement.Application.Models.Dtos
{
    public record ProductCreateDto
    {
        [Required, MaxLength(100), MinLength(3)] public string Name { get; init; }
        [Required, MaxLength(5000), MinLength(3)] public string Description { get; init; }
        [Required] public decimal Price { get; init; }
        [Required] public Guid TypeId { get; init; }
        [Required] public string CreatedBy { get; init; }
    }
}

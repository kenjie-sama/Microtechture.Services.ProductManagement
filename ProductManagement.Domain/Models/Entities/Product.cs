using ProductManagement.Domain.Enums.CodesTable;
using ProductManagement.Domain.Models.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductManagement.Domain.Models.Entities
{
    public class Product : AuditableEntity<Guid>
    {
        [Required] public string Name { get; private set; }
        [Required] public string Description { get; private set; }
        [Required] public double Price { get; private set; }
        [Required] public Guid ProductTypeId { get; private set; }

        public Product(
            string name, 
            string description,
            double price,
            Guid productTypeId,
            string createdBy)
        {
            Name = name;
            Description = description;
            Price = price;
            ProductTypeId = productTypeId;
            
            CreatedBy = createdBy;
            ModifiedBy = createdBy;
            DateTimeModified = DateTime.Now;
            IsActive = true;
        }
    }
}

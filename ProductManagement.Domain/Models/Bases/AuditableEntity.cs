using ProductManagement.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductManagement.Domain.Models.Bases
{
    public class AuditableEntity<TId> : ActivatableEntity<TId>, ICreatableByUser where TId : struct
    {
        [Required] public string CreatedBy { get; set; }
        [Required] public DateTime DateTimeCreated { get; set; } = DateTime.UtcNow;
    }
}

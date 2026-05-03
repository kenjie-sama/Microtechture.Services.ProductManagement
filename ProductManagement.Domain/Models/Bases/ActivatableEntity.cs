using ProductManagement.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Domain.Models.Bases
{
    public class ActivatableEntity<TId> : BaseEntity<TId>,  IActivatableByUser where TId : struct
    {
        public string ModifiedBy { get; set; }
        public DateTime DateTimeModified { get; set; }
        public bool IsActive { get; set; }
    }
}
 
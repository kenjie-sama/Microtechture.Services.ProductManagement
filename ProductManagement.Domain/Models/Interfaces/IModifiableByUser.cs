using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Domain.Models.Interfaces
{
    public interface IModifiableByUser : IModifiable
    {
        public string ModifiedBy { get; set; }
    }
}

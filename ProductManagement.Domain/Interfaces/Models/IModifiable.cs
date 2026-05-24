using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Domain.Interfaces.Models
{
    public interface IModifiable
    {
        public DateTime DateTimeModified { get; set; }
    }
}

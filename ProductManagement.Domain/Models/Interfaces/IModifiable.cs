using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Domain.Models.Interfaces
{
    public interface IModifiable
    {
        public DateTime DateTimeModified { get; set; }
    }
}

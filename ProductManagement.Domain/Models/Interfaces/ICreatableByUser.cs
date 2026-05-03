using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Domain.Models.Interfaces
{
    public interface ICreatableByUser : ICreatable
    {
        public string CreatedBy { get; set; }
    }
}

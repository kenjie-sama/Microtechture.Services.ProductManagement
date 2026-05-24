using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Domain.Interfaces.Models
{
    public interface IBaseEntity<TId> where TId : struct
    {
        public TId Id { get; }
    }
}

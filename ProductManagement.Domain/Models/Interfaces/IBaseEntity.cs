using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Domain.Models.Interfaces
{
    public interface IBaseEntity<TId> where TId : struct
    {
        public TId Id { get; }
    }
}

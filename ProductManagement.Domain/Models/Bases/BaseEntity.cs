using ProductManagement.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Domain.Models.Bases
{
    /// <summary>
    /// Use this as the base class for all entities in the system. 
    /// It provides a common ID property that can be used for all entities, regardless of their specific type. 
    /// This allows for a consistent way to identify and manage entities across the system.
    /// </summary>
    /// <typeparam name="TId">Provide the ID Type GUID, Integer, Long, Short, String</typeparam>
    public class BaseEntity<TId> : IBaseEntity<TId> where TId : struct
    {
        public TId Id { get; }
    }
}

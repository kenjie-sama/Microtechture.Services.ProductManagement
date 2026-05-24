using Microtechture.Common.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microtechture.Common.Interfaces.Repositories
{
    public interface IReadOnlyRepository<TReturn, in TId> where TId : struct
    {
        /// <summary>
        /// Make sure to implement with AsNoTracking() to avoid tracking the entity in the context, since it's a read-only repository.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Type Specified in TReturn</returns>
        Task<TReturn> GetByIdAsync(TId id);

        /// <summary>
        /// Make sure to implement with AsNoTracking() to avoid tracking the entity in the context, since it's a read-only repository.
        /// </summary>
        /// <returns>Type Specified in TReturn</returns>
        Task<IEnumerable<TReturn>> GetAllAsync();
    }
}

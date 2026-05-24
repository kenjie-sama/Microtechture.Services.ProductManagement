using System;
using System.Collections.Generic;
using System.Text;

namespace Microtechture.Common.Interfaces.Repositories
{
    public interface IUpsertableRepository<TEntity, TReturn, in TId> where TId : struct
    {
        Task<TReturn> UpsertAsync(TEntity entity);
    }
}

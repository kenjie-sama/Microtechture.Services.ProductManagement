using Microtechture.Common.Models.Complex;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microtechture.Common.Interfaces.Repositories
{
    public interface ICreatableRepository<in TData>
    {
        Task<TaskResult> CreateAsync(TData data);
    }
}

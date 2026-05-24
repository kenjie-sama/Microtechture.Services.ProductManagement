using Microtechture.Common.Models.Complex;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microtechture.Common.Interfaces.Repositories
{
    public interface IDeactivatableRepository<in TId> where TId : struct
    {
        Task<TaskResult> DeactivateByIdAsync(TId id);
    }
}

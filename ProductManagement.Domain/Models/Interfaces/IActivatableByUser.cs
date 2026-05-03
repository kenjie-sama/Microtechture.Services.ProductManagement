using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Domain.Models.Interfaces
{
    public interface IActivatableByUser : IModifiableByUser, IActivatable
    {
    }
}

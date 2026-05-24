using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Domain.Interfaces.Models
{
    public interface IActivatableByUser : IModifiableByUser, IActivatable
    {
    }
}

using Microtechture.Common.Interfaces.Repositories;
using ProductManagement.Application.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Application.Services.Interfaces
{
    public interface IProductService : 
        ICreatableRepository<ProductCreateDto>, 
        IReadOnlyRepository<ProductDetailDto, Guid>,
        IDeactivatableRepository<Guid>
    {
    }
}

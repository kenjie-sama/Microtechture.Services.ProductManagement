using Microtechture.Common.Interfaces.Repositories;
using ProductManagement.Domain.Models.Entities;

namespace ProductManagement.Domain.Interfaces.Repositories
{
    public interface IProductsRepository : 
        IReadOnlyRepository<Product, Guid>, 
        ICreatableRepository<Product>,
        IDeactivatableRepository<Guid>
    {
    }
}

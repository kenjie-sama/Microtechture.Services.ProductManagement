using Microsoft.EntityFrameworkCore;
using Microtechture.Common.Models.Complex;
using ProductManagement.Domain.Exceptions;
using ProductManagement.Domain.Interfaces.Repositories;
using ProductManagement.Domain.Models.Entities;
using ProductManagement.Domain.Enums.Types;
using ProductManagement.Infrastructure.Contexts;
using ProductManagement.Infrastructure.Models.DataAccessObjects;

namespace ProductManagement.Infrastructure.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ProductManagementDbContext _productManagementDbContext;
        private Entity<Product> _products;

        public ProductsRepository(ProductManagementDbContext productManagementDbContext)
        {
            _productManagementDbContext = productManagementDbContext;
            Initialize();
        }

        private void Initialize()
        {
            _products = new Entity<Product>(_productManagementDbContext.Products);
        }

        public async Task<TaskResult> CreateAsync(Product data)
        {
            await _productManagementDbContext.AddAsync(data);
            var resultId = await _productManagementDbContext.SaveChangesAsync();

            return TaskResult.GetResult(resultId, Messages.Create.Product.Success, Messages.Create.Product.Failed);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _products.Track.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            return await _products.Rows.FindAsync(id) ?? throw new InvalidOperationException(Messages.Fetch.Product.Failed);
        }

        public Task<TaskResult> DeactivateByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

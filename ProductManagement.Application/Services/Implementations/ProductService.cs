using Microtechture.Common.Models.Complex;
using ProductManagement.Application.Mappers;
using ProductManagement.Application.Models.Dtos;
using ProductManagement.Application.Services.Interfaces;
using ProductManagement.Domain.Interfaces.Repositories;

namespace ProductManagement.Application.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductsRepository _productsRepository;

        public ProductService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public async Task<TaskResult> CreateAsync(ProductCreateDto data)
        {
            var product = ProductMapper.ToProduct(data);
            return await _productsRepository.CreateAsync(product);
        }

        public async Task<TaskResult> DeactivateByIdAsync(Guid id)
        {
            return await _productsRepository.DeactivateByIdAsync(id);
        }

        public Task<IEnumerable<ProductDetailDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDetailDto> GetByIdAsync(Guid id)
        {
            var data = await _productsRepository.GetByIdAsync(id);

            return ProductMapper.ToProductDetail(data);
        }
    }
}

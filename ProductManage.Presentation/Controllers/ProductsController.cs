using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Domain.Interfaces.Repositories;

namespace ProductManage.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsRepository _productsRepository;
    }
}

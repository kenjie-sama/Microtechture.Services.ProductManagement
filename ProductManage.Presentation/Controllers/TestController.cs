using Microsoft.AspNetCore.Mvc;

namespace ProductManage.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public Task<IActionResult> Get()
        {
            return Task.FromResult<IActionResult>(Ok("Test successful"));
        }
    }
}

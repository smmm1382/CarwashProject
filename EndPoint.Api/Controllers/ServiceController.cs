using CarwashProject.Application.Services.CarwashServices.Queries.Create;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly ICreate2 _create2;
        public ServiceController(ICreate2 create2)
        {
            _create2 = create2;
        }

        [HttpGet]

        public IActionResult GetService(CreateServiceDto createService)
        {
            var service = _create2.Execute(createService);
            return Ok(service);
        }
    }
}

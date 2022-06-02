using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Vrudi_MVP_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {

        [HttpGet]
        [Authorize]

        [Route("sampletest")]
        public IActionResult testEndpoint()
        {
            return Ok();
        }

    }
}

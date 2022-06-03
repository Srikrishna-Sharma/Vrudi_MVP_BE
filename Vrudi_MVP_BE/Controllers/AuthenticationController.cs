using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vrudi_MVP_BE.DTOs;
using Vrudi_MVP_BE.Services.Interfaces;

namespace Vrudi_MVP_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ICredentialsManagerService _authenticationManager;
        public AuthenticationController(ICredentialsManagerService authenticationManager)
        {
            _authenticationManager = authenticationManager;
        }

        [HttpPost]
        [Route("authenticate")]

        public IActionResult Authenticate([FromBody] UserCredentials credentials)
        {
            if (string.IsNullOrEmpty(credentials.Email) || string.IsNullOrEmpty(credentials.Password))
                return BadRequest("Username and/or Password not specified");

            string token = _authenticationManager.Authenticate(credentials.Email, credentials.Password);
            if (string.IsNullOrEmpty(token))
                return Unauthorized("Invalid Credentials");
            else return Ok(token);
        }
    }
}

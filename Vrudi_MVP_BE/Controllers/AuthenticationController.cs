using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vrudi_MVP_BE.DTOs;
using Vrudi_MVP_BE.Helpers.interfaces;
using Vrudi_MVP_BE.Services.Interfaces;

namespace Vrudi_MVP_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ICredentialsManagerService _authenticationManager;
        private readonly ILoggerManager _logger;

        public AuthenticationController(ICredentialsManagerService authenticationManager, ILoggerManager logger)
        {
            _authenticationManager = authenticationManager;
            _logger = logger;

        }

        [HttpGet]
        [Route("authenticate")]

        public IActionResult Authenticate([FromQuery]string email, string password)
        {
            _logger.LogInfo("Testing logs");

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                return BadRequest("Email and/or Password not specified");

            string token = _authenticationManager.Authenticate(email, password);
            if (string.IsNullOrEmpty(token))
                return Unauthorized("Invalid Credentials");
            else return Ok(token);
        }

        [HttpGet]
        [Route("forgotpassword")]
        public IActionResult ForgotPassword([FromQuery] string email, string securityQuestion, string securityAnswer)
        {
            if ( string.IsNullOrEmpty(email))
                return BadRequest("Email is not specified");
          
            if (_authenticationManager.ValidateSecurityQuestions(email,securityQuestion,securityAnswer))
                return Ok(" Please Reset the Password");
            else return Unauthorized("Invalid Credentials");

        }


        [HttpPost]
        [Route("resetpassword")]
        public IActionResult ResetPassword([FromBody] UserCredentials credentials)
        {

            if (_authenticationManager.ResetPasword(credentials))
                return Ok("Password Has been set succcessfully");
            else return Unauthorized("Invalid Credentials");

        }
    }
}

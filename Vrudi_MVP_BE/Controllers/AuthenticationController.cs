using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vrudi_MVP_BE.DTOs;
using Vrudi_MVP_BE.Helpers.interfaces;
using Vrudi_MVP_BE.Helpers.Services;
using Vrudi_MVP_BE.Services.Interfaces;

namespace Vrudi_MVP_BE.Controllers
{
    
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
        [Route("/authenticate")]

        public IActionResult Authenticate([FromQuery]string email, string password)
        {

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                string error = "Email and/or Password not specified";
             
                return BadRequest(DataWrapperService.WrapData(error, false));
            }
                

            string token = _authenticationManager.Authenticate(email, password);
            if (string.IsNullOrEmpty(token))
            {
                string error = "Invalid Credentials";

                return Unauthorized(DataWrapperService.WrapData(error, false));
            }
                
            else
            {
                string success = "Data Found Successfully";
                Dictionary<string, string> tokenPair = new Dictionary<string, string>();
                tokenPair.Add("token", token);
                return Ok(DataWrapperService.WrapData(success, true, tokenPair));
            }
            
        }

        [HttpGet]
        [Route("/forgotpassword")]
        public IActionResult ForgotPassword([FromQuery] string email, string securityQuestion, string securityAnswer)
        {
            if ( string.IsNullOrEmpty(email))
            {
                string error = "Email is not specified";

                return BadRequest(DataWrapperService.WrapData(error, false));
            }


            if (_authenticationManager.ValidateSecurityQuestions(email, securityQuestion, securityAnswer))
            {
                string success = "Please Reset the Password";
                return Ok(DataWrapperService.WrapData(success, true));
            }
            
            else
            {
                string error = "Invalid Credentials";
                return Unauthorized(DataWrapperService.WrapData(error, false));
            } 

        }


        [HttpPost]
        [Route("/resetpassword")]
        public IActionResult ResetPassword([FromBody] UserCredentials credentials)
        {

            if (_authenticationManager.ResetPasword(credentials))
            {
                string success = "Password Has been set succcessfully";
                return Ok(DataWrapperService.WrapData(success, true));
            }
            else {
                string error = "Invalid Credentials";
                return Unauthorized(DataWrapperService.WrapData(error, false));
            }

        }

        [HttpPost]
        [Route("/signup")]
        public IActionResult SignUp([FromBody] UserCredentials credentials)
        {

            if (_authenticationManager.SignUp(credentials))
            {
                string success = "You have been signed up succcessfully";
                return Ok(DataWrapperService.WrapData(success, true));
            }
            else
            {
                string error = "Invalid Details";
                return BadRequest(DataWrapperService.WrapData(error, false));
            }

        }
    }
}

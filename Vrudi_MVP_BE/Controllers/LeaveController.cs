using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vrudi_MVP_BE.DTOs;
using Vrudi_MVP_BE.Helpers.interfaces;
using Vrudi_MVP_BE.Helpers.Services;
using Vrudi_MVP_BE.Services.Interfaces;

namespace Vrudi_MVP_BE.Controllers
{
    [ApiController]
    [Authorize]
    public class LeaveController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly ILeaveService _leave;

        public LeaveController(ILoggerManager logger, ILeaveService leave)
        {
            _logger = logger;
            _leave = leave;
        }

        [HttpPost]
        [Route("/createleave")]
        public IActionResult CreateLeave([FromBody] LeaveTypeDTO details)
        {

            if (_leave.CreateLeave(details))
            {
                string success = "Leaves are created successfully";
                return Ok(DataWrapperService.WrapData(success, true));
            }
            else
            {
                string error = "Invalid Details";
                return BadRequest(DataWrapperService.WrapData(error, false));
            }

        }

        [HttpGet]
        [Route("/getleaves")]
        
        public IActionResult GetAllLeave()
        {

            var leave = _leave.GetAllLeaves();

            if (leave.Any())
            {
                string success = "Data Found Successfully";
                return Ok(DataWrapperService.WrapData(success, true, leave));
            }
            else
            {
                string error = "No data found";

                return BadRequest(DataWrapperService.WrapData(error, false));
            }

        }
    }
}

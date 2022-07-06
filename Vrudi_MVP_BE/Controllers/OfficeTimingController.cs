using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vrudi_MVP_BE.DTOs;
using Vrudi_MVP_BE.Helpers.interfaces;
using Vrudi_MVP_BE.Helpers.Services;
using Vrudi_MVP_BE.Services.Interfaces;

namespace Vrudi_MVP_BE.Controllers
{
    [Authorize]
    [ApiController]
    public class OfficeTimingController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly IOfficeTimingsService _office;

        public OfficeTimingController(ILoggerManager logger, IOfficeTimingsService office)
        {
            _logger = logger;
            _office = office;
        }

        [HttpPost]
        [Route("/saveorupdatetimings")]
        public IActionResult SaveOrUpdateTimings([FromBody] OfficeTimingsDto details)
        {

            if (_office.SaveOrUpdateOfficeTimings(details))
            {
                string success = "Office Timings are saved successfully";
                return Ok(DataWrapperService.WrapData(success, true));
            }
            else
            {
                string error = "Invalid Details";
                return BadRequest(DataWrapperService.WrapData(error, false));
            }

        }

        [HttpGet]
        [Route("/getofficetimings/{email}")]

        public IActionResult GetOfficeTimings(string email)
        {

            var office = _office.GetOfficeTimings(email);

            if (office != null)
            {
                string success = "Data Found Successfully";
                return Ok(DataWrapperService.WrapData(success, true, office));
            }
            else
            {
                string error = "No data found";

                return BadRequest(DataWrapperService.WrapData(error, false));
            }

        }
    }
}

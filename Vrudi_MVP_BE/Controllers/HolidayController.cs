using Microsoft.AspNetCore.Mvc;
using Vrudi_MVP_BE.DTOs;
using Vrudi_MVP_BE.Helpers.interfaces;
using Vrudi_MVP_BE.Helpers.Services;
using Vrudi_MVP_BE.Services.Interfaces;

namespace Vrudi_MVP_BE.Controllers
{
    public class HolidayController : ControllerBase
    {
        private readonly IHolidayService _holidays;
        private readonly ILoggerManager _logger;

        public HolidayController(IHolidayService holiday, ILoggerManager logger)
        {
            _holidays = holiday;
            _logger = logger;

        }

        [HttpPost]
        [Route("/saveholidays")]
        public IActionResult SaveHolidays([FromBody] HolidaysDto holiday)
        {

            if (_holidays.SaveHoliday(holiday))
            {
                string success = "Holiday has been set succcessfully";
                return Ok(DataWrapperService.WrapData(success, true));
            }
            else
            {
                string error = "Error while saving holiday";
                return BadRequest(DataWrapperService.WrapData(error, false));
            }

        }

        [HttpGet]
        [Route("/getAllHolidays")]

        public IActionResult GetHolidays()
        {
            

            var holidays = _holidays.GetAllHolidays();

            if(holidays.Any())
            {
                string success = "Data Found Successfully";
                return Ok(DataWrapperService.WrapData(success, true, holidays));
            }
            else
            {
                string error = "No data found";

                return BadRequest(DataWrapperService.WrapData(error, false));
            }

        }


    }
}

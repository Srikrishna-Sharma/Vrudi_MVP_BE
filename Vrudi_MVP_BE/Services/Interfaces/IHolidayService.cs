using Vrudi_MVP_BE.DTOs;

namespace Vrudi_MVP_BE.Services.Interfaces
{
    public interface IHolidayService
    {
        public bool SaveHoliday(HolidaysDto holiday);
        public List<HolidaysDto> GetAllHolidays();
    }
}

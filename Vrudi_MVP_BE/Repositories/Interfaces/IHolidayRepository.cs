using Vrudi_MVP_BE.DTOs;
using Vrudi_MVP_BE.Repositories.DbTables;

namespace Vrudi_MVP_BE.Repositories.Interfaces
{
    public interface IHolidayRepository
    {
        bool SaveHoliday(Holidays holiday);
        public List<Holidays> GetAllHolidays();
    }
}

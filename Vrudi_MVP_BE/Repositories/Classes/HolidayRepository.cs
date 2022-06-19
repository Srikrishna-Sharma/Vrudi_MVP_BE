using Vrudi_MVP_BE.Repositories.DbTables;
using Vrudi_MVP_BE.Repositories.Interfaces;
using Vrudi_MVP_BE.VrDbContext;

namespace Vrudi_MVP_BE.Repositories.Classes
{
    public class HolidayRepository : IHolidayRepository
    {
        private readonly VrudiDbContext _dbContext;
        public HolidayRepository(VrudiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Holidays> GetAllHolidays()
        {
            var result = _dbContext.holiday.Where(x => x.Id > 0).ToList();
            return result;
        }

        public bool SaveHoliday(Holidays holiday)
        {
            var result = _dbContext.holiday.Add(holiday);
            var rowCount = _dbContext.SaveChanges();

            return rowCount > 0 ? true : false;

        }


    }
}

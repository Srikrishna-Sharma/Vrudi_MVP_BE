using Vrudi_MVP_BE.Repositories.DbTables;
using Vrudi_MVP_BE.Repositories.Interfaces;
using Vrudi_MVP_BE.VrDbContext;

namespace Vrudi_MVP_BE.Repositories.Classes
{
    public class OfficeTimingRepository : IOfficeTimingRepository
    {
        private readonly VrudiDbContext _dbContext;
        public OfficeTimingRepository(VrudiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public OfficeTimings GetOfficeTimings(string officeEmail)
        {
            var result = _dbContext.officeTimings.FirstOrDefault(x => x.OfficeEmail == officeEmail);
            return result;
        }

        public bool SaveOrUpdateOfficeTimings(OfficeTimings officeTimings)
        {
            var result = _dbContext.officeTimings.FirstOrDefault(x => x.OfficeEmail == officeTimings.OfficeEmail);
            if (result?.OfficeEmail == officeTimings.OfficeEmail)
            {
                result.StartTime = officeTimings.StartTime;
                result.EndTime = officeTimings.EndTime;
                result.EarlyThreshold = officeTimings.EarlyThreshold;
                result.LateThreshold = officeTimings.LateThreshold;
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                _dbContext.officeTimings.Add(officeTimings);
                var rowCount = _dbContext.SaveChanges();

                return rowCount > 0 ? true : false;
            }

        }

    }
}

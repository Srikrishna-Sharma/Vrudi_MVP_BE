using Vrudi_MVP_BE.Repositories.DbTables;

namespace Vrudi_MVP_BE.Repositories.Interfaces
{
    public interface IOfficeTimingRepository
    {
        public OfficeTimings GetOfficeTimings(string officeEmail);
        public bool SaveOrUpdateOfficeTimings(OfficeTimings officeTimings);
    }
}

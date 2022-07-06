using Vrudi_MVP_BE.DTOs;

namespace Vrudi_MVP_BE.Services.Interfaces
{
    public interface IOfficeTimingsService
    {
        public OfficeTimingsDto GetOfficeTimings(string officeEmail);
        public bool SaveOrUpdateOfficeTimings(OfficeTimingsDto officeTimings);
    }
}

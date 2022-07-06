using AutoMapper;
using Vrudi_MVP_BE.DTOs;
using Vrudi_MVP_BE.Repositories.DbTables;
using Vrudi_MVP_BE.Repositories.Interfaces;
using Vrudi_MVP_BE.Services.Interfaces;

namespace Vrudi_MVP_BE.Services.Classes
{
    public class OfficeTimingsService : IOfficeTimingsService
    {
        public IOfficeTimingRepository _officeTimingRepository { get; set; }
        private readonly IMapper _mapper;

        public OfficeTimingsService(IOfficeTimingRepository officeTimingRepository, IMapper mapper)
        {
            _officeTimingRepository = officeTimingRepository;
            _mapper = mapper;
        }
        public OfficeTimingsDto GetOfficeTimings(string officeEmail)
        {
            return _mapper.Map<OfficeTimingsDto> (_officeTimingRepository.GetOfficeTimings(officeEmail));
        }

        public bool SaveOrUpdateOfficeTimings(OfficeTimingsDto officeTimings)
        {
            var office = _mapper.Map<OfficeTimings>(officeTimings);
            return _officeTimingRepository.SaveOrUpdateOfficeTimings(office);
        }
    }
}

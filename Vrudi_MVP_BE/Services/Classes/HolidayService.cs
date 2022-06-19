using AutoMapper;
using Vrudi_MVP_BE.DTOs;
using Vrudi_MVP_BE.Repositories.DbTables;
using Vrudi_MVP_BE.Repositories.Interfaces;
using Vrudi_MVP_BE.Services.Interfaces;

namespace Vrudi_MVP_BE.Services.Classes
{
    public class HolidayService : IHolidayService
    {
        public IHolidayRepository _holidayRepository { get; set; }
        private readonly IMapper _mapper;

        public HolidayService(IHolidayRepository holidayRepository, IMapper mapper)
        {
            _holidayRepository = holidayRepository;
            _mapper = mapper;
        }
        public bool SaveHoliday(HolidaysDto holiday)
        {
            var holi = _mapper.Map<Holidays>(holiday);
            return _holidayRepository.SaveHoliday(holi);
        }

        public List<HolidaysDto> GetAllHolidays()
        {
            return _mapper.Map<List<HolidaysDto>>(_holidayRepository.GetAllHolidays());
        }
    }
}

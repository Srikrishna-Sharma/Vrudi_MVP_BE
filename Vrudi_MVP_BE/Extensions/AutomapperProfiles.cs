using AutoMapper;
using Vrudi_MVP_BE.DTOs;
using Vrudi_MVP_BE.Repositories.DbTables;

namespace Vrudi_MVP_BE.Extensions
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<UserCredentialsDto, UserLogin>().ReverseMap();
            CreateMap<HolidaysDto, Holidays>().ReverseMap();
            CreateMap<LeaveTypeDTO, LeaveType>().ReverseMap();
            CreateMap<EmployeeDetailsDto, Employees>().ReverseMap();
            CreateMap<ClientDetailsDto, Clients>().ReverseMap();
            CreateMap<ProfessionalDetailsDto, Professionals>().ReverseMap();
            CreateMap<OfficeTimingsDto, OfficeTimings>().ReverseMap();

        }
    }
}

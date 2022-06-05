using AutoMapper;
using Vrudi_MVP_BE.DTOs;
using Vrudi_MVP_BE.Repositories.DbTables;

namespace Vrudi_MVP_BE.Extensions
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<UserCredentials, UserLogin>().ReverseMap();
        }
    }
}

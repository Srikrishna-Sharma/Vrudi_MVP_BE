using AutoMapper;
using Vrudi_MVP_BE.DTOs;
using Vrudi_MVP_BE.Repositories.DbTables;
using Vrudi_MVP_BE.Repositories.Interfaces;
using Vrudi_MVP_BE.Services.Interfaces;

namespace Vrudi_MVP_BE.Services.Classes
{
    public class LeaveService : ILeaveService
    {
        private readonly IMapper _mapper;
        private readonly ILeaveRepository _leave;

        public LeaveService(IMapper mapper, ILeaveRepository leave)
        {
            _mapper = mapper;
            _leave = leave;
        }

        public bool CreateLeave(LeaveTypeDTO details)
        {
            var leave = _mapper.Map<LeaveType>(details);
            return _leave.CreateLeave(leave);
        }

        public List<LeaveTypeDTO> GetAllLeaves()
        {
            return _mapper.Map<List<LeaveTypeDTO>>(_leave.GetAllLeaves());
        }
    }
}

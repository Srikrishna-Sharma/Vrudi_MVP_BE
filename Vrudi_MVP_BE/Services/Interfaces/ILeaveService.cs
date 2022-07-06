using Vrudi_MVP_BE.DTOs;

namespace Vrudi_MVP_BE.Services.Interfaces
{
    public interface ILeaveService
    {
        bool CreateLeave(LeaveTypeDTO details);
        public List<LeaveTypeDTO> GetAllLeaves();
    }
}

using Vrudi_MVP_BE.Repositories.DbTables;

namespace Vrudi_MVP_BE.Repositories.Interfaces
{
    public interface ILeaveRepository
    {
        bool CreateLeave(LeaveType leaveType);
        public List<LeaveType> GetAllLeaves();
    }
}

using Vrudi_MVP_BE.Repositories.DbTables;
using Vrudi_MVP_BE.Repositories.Interfaces;
using Vrudi_MVP_BE.VrDbContext;

namespace Vrudi_MVP_BE.Repositories.Classes
{
    public class LeaveRepository : ILeaveRepository
    {
        private readonly VrudiDbContext _dbContext;
        public LeaveRepository(VrudiDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool CreateLeave(LeaveType leaveType)
        {
            var result = _dbContext.leaveTypes.Add(leaveType);
            var rowCount = _dbContext.SaveChanges();

            return rowCount > 0 ? true : false;
        }

        public List<LeaveType> GetAllLeaves()
        {
            var result = _dbContext.leaveTypes.Where(x => x.Id > 0).ToList();
            return result;
        }
    }
}

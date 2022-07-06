using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vrudi_MVP_BE.Repositories.DbTables
{
    public class LeaveRequests : BaseTable
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }
        public List<DateTime> LeaveDates { get; set; }
        public string SubmittedBy { get; set; }
        public string LeaveReason { get; set; }
        public string ApprovedBy { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }
        
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vrudi_MVP_BE.Repositories.DbTables
{
    public class UserLeaves : BaseTable
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }

        [Display(Name = "UserLogin")]
        public virtual int Email { get; set; }

        [ForeignKey("Email")]
        public virtual UserLogin User { get; set; }

        public string LeaveType { get; set; }
        public int TotalLeaves { get; set; }
        public int BalanceLeaves { get; set; }
       
    }
}


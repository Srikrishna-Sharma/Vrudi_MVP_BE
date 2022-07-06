using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vrudi_MVP_BE.Repositories.DbTables
{
    public class LeaveType : BaseTable
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string DeductionType { get; set; }
        public int DeductionValue { get; set; }
        public int CapYearly { get; set; }
        public int CapMonthly { get; set; }

    }
}

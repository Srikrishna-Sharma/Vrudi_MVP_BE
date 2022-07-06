using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vrudi_MVP_BE.Repositories.DbTables
{
    public class Employees : BaseTable
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PermanentAddress { get; set; }
        public string CurrentAddress { get; set; }
        public string Gender { get; set; }
        public string PersonalEmail { get; set; }
        public string MobileNumber { get; set; }
        public string EmergencyContact { get; set; }
        public DateTime Dob { get; set; }
        public string AadharNumber { get; set; }
        public string PanNumber { get; set; }
        public string BankAccountNumber { get; set; }
        public string IfscCode { get; set; }  
        public string BankName { get; set; }
        public string Photo { get; set; }
        public string AadharPhoto { get; set; }
        public string PanPhoto { get; set; }
        public double BasicSalary { get; set; }
        public double Hra { get; set; }
        public double MonthlyAllowance { get; set; }
        public DateTime SalaryDueDate { get; set; }
        public string EmployeeType { get; set; }
        public string EmployeeStatus { get; set; }
        public DateTime JoiningDate { get; set; }
    }
}

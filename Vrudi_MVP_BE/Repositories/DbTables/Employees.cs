using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vrudi_MVP_BE.Repositories.DbTables
{
    public class Employees
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PermanentAddress { get; set; }
        public string CurrentAddress { get; set; }
        public string Gender { get; set; }
        public string PersonalEmail { get; set; }
        public int MobileNumber { get; set; }
        public int EmergencyContact { get; set; }
        public DateTime Dob { get; set; }
        public int AadharNumber { get; set; }
        public int PanNumber { get; set; }
        public int BankAccountNumber { get; set; }
        public string IfscCode { get; set; }  
        public string BankName { get; set; }
        public string Photo { get; set; }
        public string AadharPhoto { get; set; }
        public string PanPhoto { get; set; }
        public int BasicSalary { get; set; }
        public int Hra { get; set; }
        public int MonthlyAllowance { get; set; }
        public DateTime SalaryDueDate { get; set; }
        public string EmployeeType { get; set; }
        public string EmployeeStatus { get; set; }
        public DateTime JoiningDate { get; set; }
    }
}

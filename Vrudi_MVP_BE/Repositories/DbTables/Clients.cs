using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vrudi_MVP_BE.Repositories.DbTables
{
    public class Clients : BaseTable
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }
        public string OrganisationName { get; set; }
        public string OrganisationType { get; set; }
        public string PermanentAddress { get; set; }
        public string ContactName { get; set; }
        public string OrganisationMail { get; set; }
        public string PersonalEmail { get; set; }
        public string MobileNumber { get; set; }
        public string ContactMobileNumber { get; set; }
        public DateTime RegDate { get; set; }
        public string GstNumber { get; set; }
        public string PanNumber { get; set; }
        public string BankAccountNumber { get; set; }
        public string IfscCode { get; set; }
        public string BankName { get; set; }
        public double OpeningBal { get; set; }
    }
}

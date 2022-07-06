namespace Vrudi_MVP_BE.DTOs
{
    public class ProfessionalDetailsDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string RegisteredEmail { get; set; }
        public string RegisteredMobileNumber { get; set; }
        public string Gender { get; set; }
        public string OrganisationName { get; set; }
        public string OrganisationType { get; set; }
        public string Industry { get; set; }
        public string PermanentAddress { get; set; }
        public string OrganisationMail { get; set; }
        public string ContactNumber { get; set; }
        public DateTime RegDate { get; set; }
        public string GstType { get; set; }
        public string GstNumber { get; set; }
        public string PanNumber { get; set; }
        public string TanNumber { get; set; }
        public string BankAccountNumber { get; set; }
        public string IfscCode { get; set; }
        public string BankName { get; set; }
    }
}

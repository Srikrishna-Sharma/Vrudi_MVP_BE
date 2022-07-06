namespace Vrudi_MVP_BE.DTOs
{
    public class LeaveTypeDTO
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string DeductionType { get; set; }
        public int DeductionValue { get; set; }
        public int CapYearly { get; set; }
        public int CapMonthly { get; set; }
    }
}

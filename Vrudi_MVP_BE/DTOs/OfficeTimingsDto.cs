namespace Vrudi_MVP_BE.DTOs
{
    public class OfficeTimingsDto
    {
        public string OfficeEmail { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime EarlyThreshold { get; set; }
        public DateTime LateThreshold { get; set; }
    }
}

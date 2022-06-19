namespace Vrudi_MVP_BE.DTOs
{
    public class HolidaysDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        

    }
}

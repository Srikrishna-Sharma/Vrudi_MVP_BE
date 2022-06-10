namespace Vrudi_MVP_BE.DTOs
{
    public class DataWrapper
    {
        public bool success { get; set; }
        public string message { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public Object dataObject { get; set; }
    }
}

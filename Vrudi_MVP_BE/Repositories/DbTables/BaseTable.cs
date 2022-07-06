namespace Vrudi_MVP_BE.Repositories.DbTables
{
    public class BaseTable
    {
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; } = "test_admin";

    }
}

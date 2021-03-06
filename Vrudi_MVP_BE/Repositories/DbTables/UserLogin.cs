using System.ComponentModel.DataAnnotations;

namespace Vrudi_MVP_BE.Repositories.DbTables
{
    public class UserLogin : BaseTable
    {
        [Key]
        public string Email { get; set; }

        public string Password { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Usertype { get; set; }
        public string Professional { get; set; }
        public string SecurityQuestion { get; set; } = null;
        public string SecurityAnswer { get; set; }= null;
    }
}

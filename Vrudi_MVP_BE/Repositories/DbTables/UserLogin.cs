using System.ComponentModel.DataAnnotations;

namespace Vrudi_MVP_BE.Repositories.DbTables
{
    public class UserLogin
    {
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }
        public string SecurityQuestion { get; set; } = null;
        public string SecurityAnswer { get; set; }= null;
    }
}

using Vrudi_MVP_BE.Repositories.DbTables;
using Vrudi_MVP_BE.Repositories.Interfaces;
using Vrudi_MVP_BE.VrDbContext;
namespace Vrudi_MVP_BE.Repositories.Classes
{
    public class CredentialRepository : ICredentialRepository
    {
        private readonly VrudiDbContext _dbContext;

        public CredentialRepository(VrudiDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool ValidateCredentials(string email, string password)
        {
           return _dbContext.userLogins.Any(cred => cred.Email == email && cred.Password == password);
        }
        public bool ValidateSecurityQuestions(string email, string question, string answer)
        {
            return _dbContext.userLogins.Any(cred => cred.Email == email && cred.SecurityQuestion == question
                    && cred.SecurityAnswer == answer);
        }
        public bool ResetPasword(UserLogin changePassword)
        {
            var result = _dbContext.userLogins.SingleOrDefault(cred => cred.Email == changePassword.Email);
            if(result != null)
            {
                result.Password = changePassword.Password;
                 _dbContext.SaveChanges();
                return true;
            }

            return false;

        }
    }
}

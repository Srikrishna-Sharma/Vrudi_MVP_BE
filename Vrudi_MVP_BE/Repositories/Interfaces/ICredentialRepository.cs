using Vrudi_MVP_BE.Repositories.DbTables;

namespace Vrudi_MVP_BE.Repositories.Interfaces
{
    public interface ICredentialRepository
    {
        bool ValidateCredentials(string username, string password);
        bool ValidateSecurityQuestions(string email, string question, string answer);
        bool ResetPasword(UserLogin userLogin);
        bool AddUserDetails(UserLogin addUser);
        bool AddEmployee(Employees employee);
        
    }
}

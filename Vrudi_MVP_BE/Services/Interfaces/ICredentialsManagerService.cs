using Vrudi_MVP_BE.DTOs;

namespace Vrudi_MVP_BE.Services.Interfaces
{
    public interface ICredentialsManagerService
    {
        public string Authenticate(string email, string password);
        bool ValidateSecurityQuestions(string email, string question, string answer);
        bool ResetPasword(UserCredentials credentials);
        bool SignUp(UserCredentials credentials);
        bool EmployeeSignUp(EmployeeDetails details);


    }
}

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
        bool AddClient(Clients client);
        bool AddProfessional(Professionals professional);
        Employees GetEmployeeByEmail(string email);
        List<Employees> GetAllEmployees();
        Professionals GetProfessionalByEmail(string email);
        List<Professionals> GetAllProfessionals();
        Clients GetClientByEmail(string email);
        List<Clients> GetAllClients();
    }
}

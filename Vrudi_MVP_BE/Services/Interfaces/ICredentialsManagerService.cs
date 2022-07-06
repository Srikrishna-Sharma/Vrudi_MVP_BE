using Vrudi_MVP_BE.DTOs;

namespace Vrudi_MVP_BE.Services.Interfaces
{
    public interface ICredentialsManagerService
    {
        public string Authenticate(string email, string password);
        bool ValidateSecurityQuestions(string email, string question, string answer);
        bool ResetPasword(UserCredentialsDto credentials);
        bool SignUp(UserCredentialsDto credentials);
        bool EmployeeSignUp(EmployeeDetailsDto details);
        bool ClientSignUp(ClientDetailsDto details);
        bool ProfessionalSignUp(ProfessionalDetailsDto details);
        public List<EmployeeDetailsDto> GetAllEmployees();
        public List<ClientDetailsDto> GetAllClients();
        public List<ProfessionalDetailsDto> GetAllProfessionals();
        public EmployeeDetailsDto GetEmployeeByEmail(string email);
        public ProfessionalDetailsDto GetProfessionalByEmail(string email);
        public ClientDetailsDto GetClientByEmail(string email);
        
    }
}

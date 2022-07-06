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

        public bool AddUserDetails(UserLogin userDetails)
        {
            var result = _dbContext.userLogins.Add(userDetails);
            var rowCount = _dbContext.SaveChanges();

            return rowCount > 0 ? true : false;
            

        }

        public bool AddEmployee(Employees employee)
        {
            var result = _dbContext.employee.Add(employee);
            var rowCount = _dbContext.SaveChanges();

            return rowCount > 0 ? true : false;


        }

        public bool AddClient(Clients client)
        {
            var result = _dbContext.clients.Add(client);
            var rowCount = _dbContext.SaveChanges();

            return rowCount > 0 ? true : false;
        }

        public bool AddProfessional(Professionals professional)
        {
            var result = _dbContext.professionals.Add(professional);
            var rowCount = _dbContext.SaveChanges();

            return rowCount > 0 ? true : false;
        }

        public Employees GetEmployeeByEmail(string email)
        {
            return _dbContext.employee?.FirstOrDefault(x => x.PersonalEmail == email);
        }

        public List<Employees> GetAllEmployees()
        {
            return _dbContext.employee?.Where(x => x.IsActive)?.ToList();
        }

        public Professionals GetProfessionalByEmail(string email)
        {
            return _dbContext.professionals?.FirstOrDefault(x => x.RegisteredEmail == email);
        }

        public List<Professionals> GetAllProfessionals()
        {
            return _dbContext.professionals?.Where(x => x.IsActive)?.ToList();
        }

        public Clients GetClientByEmail(string email)
        {
            return _dbContext.clients?.FirstOrDefault(x => x.OrganisationMail == email);
        }

        public List<Clients> GetAllClients()
        {
            return _dbContext.clients?.Where(x => x.IsActive)?.ToList();
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Vrudi_MVP_BE.DTOs;
using Vrudi_MVP_BE.Repositories.DbTables;
using Vrudi_MVP_BE.Repositories.Interfaces;
using Vrudi_MVP_BE.Services.Interfaces;

namespace Vrudi_MVP_BE.Services.Classes
{
    public class CredentialsManagerService : ICredentialsManagerService
    {
        public ICredentialRepository _credentialRepository { get; set; }
        private readonly IMapper _mapper;

        public CredentialsManagerService(ICredentialRepository credentialRepository, IMapper mapper)
        {
            _credentialRepository = credentialRepository;
            _mapper = mapper;
        }
        public string Authenticate(string email, string password)
        {
           
            if (_credentialRepository.ValidateCredentials(email,password)) //TODO: change later
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.UTF8.GetBytes("thisisasecretkey@123");
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                  {
                    new Claim(ClaimTypes.Name, email)
                  }),
                    Expires = DateTime.UtcNow.AddMinutes(10),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
                           }
            else return null;
            
          
        }

        public bool ValidateSecurityQuestions(string email, string question, string answer)
        {
            return _credentialRepository.ValidateSecurityQuestions(email, question, answer);
        }
        public bool ResetPasword(UserCredentialsDto credentials)
        {
            var creds = _mapper.Map<UserLogin>(credentials);
            return _credentialRepository.ResetPasword(creds);
        }
        public bool SignUp(UserCredentialsDto credentials)
        {
            var creds = _mapper.Map<UserLogin>(credentials);
            return _credentialRepository.AddUserDetails(creds);
            //if (_credentialRepository.AddUserDetails(email, fullname, username, password, usertype, professional, securityQuestion, securityAnswer))
            //{
            //    return true;
            //}
            //else return false;

        }
        public bool EmployeeSignUp(EmployeeDetailsDto details)
        {
            var info = _mapper.Map<Employees>(details);
            return _credentialRepository.AddEmployee(info);

        }

        public bool ClientSignUp(ClientDetailsDto details)
        {
            var info = _mapper.Map<Clients>(details);
            return _credentialRepository.AddClient(info);
        }

        public bool ProfessionalSignUp(ProfessionalDetailsDto details)
        {
            var info = _mapper.Map<Professionals>(details);
            return _credentialRepository.AddProfessional(info);
        }

        public List<EmployeeDetailsDto> GetAllEmployees()
        {
            return _mapper.Map<List<EmployeeDetailsDto>>(_credentialRepository.GetAllEmployees());
        }

        public List<ClientDetailsDto> GetAllClients()
        {
            return _mapper.Map<List<ClientDetailsDto>>(_credentialRepository.GetAllClients());
        }

        public List<ProfessionalDetailsDto> GetAllProfessionals()
        {
            return _mapper.Map<List<ProfessionalDetailsDto>>(_credentialRepository.GetAllProfessionals());
        }

        public EmployeeDetailsDto GetEmployeeByEmail(string email)
        {
            return _mapper.Map<EmployeeDetailsDto>(_credentialRepository.GetEmployeeByEmail(email));
        }

        public ProfessionalDetailsDto GetProfessionalByEmail(string email)
        {
            return _mapper.Map<ProfessionalDetailsDto>(_credentialRepository.GetProfessionalByEmail(email));
        }

        public ClientDetailsDto GetClientByEmail(string email)
        {
            return _mapper.Map<ClientDetailsDto>(_credentialRepository.GetClientByEmail(email));
        }
    }
    
}

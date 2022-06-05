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
        public bool ResetPasword(UserCredentials credentials)
        {
            var creds = _mapper.Map<UserLogin>(credentials);
            return _credentialRepository.ResetPasword(creds);
        }
    }
    
}

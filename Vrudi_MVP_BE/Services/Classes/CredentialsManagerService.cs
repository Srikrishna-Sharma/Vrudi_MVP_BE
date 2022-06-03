using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Vrudi_MVP_BE.Services.Interfaces;

namespace Vrudi_MVP_BE.Services.Classes
{
    public class CredentialsManagerService : ICredentialsManagerService
    {
        public string Authenticate(string email, string password)
        {
           
            if (true) //TODO: change later
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
    }
    
}

using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ApprovalIntelogix.Helpers;
using ApprovalIntelogix.Models;

namespace ApprovalIntelogix.Services
{

    public interface IUserService
    {
        Users Authenticate(Users users);
    }

    public class UserService : IUserService
    {
        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public Users Authenticate(Users users)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, users.Username),
                    new Claim(ClaimTypes.Role, users.Password),
                    new Claim(ClaimTypes.NameIdentifier,users.IdEmployee)
                 
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)

            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            users.token = tokenHandler.WriteToken(token);

            return users;
        }
    }
}

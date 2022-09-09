using Inficare.Bank.Service.Interface.Authentication;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Inficare.Bank.Infrastructure.Authentication
{
    public class GenerateJwtToken:ITokenGenerator
    {
        private IConfiguration _configuration;
        private double _tokenExpiry;

        public GenerateJwtToken(IConfiguration configuration)
        {
            _configuration = configuration;
            _tokenExpiry = Convert.ToDouble(_configuration.GetSection("TokenExpireIn").Value.ToString()); ;
        }

        public string GenerateToken(string email)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration.GetSection("SecuredKey").Value.ToString());
            ClaimsIdentity claims = new ClaimsIdentity();
            claims.AddClaim(new Claim(ClaimTypes.Name, email));

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claims,
                Expires = DateTime.UtcNow.AddSeconds(_tokenExpiry),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}

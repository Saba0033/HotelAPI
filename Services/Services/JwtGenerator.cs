using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using HotelAPI.Application.Interfaces;
using HotelAPI.Domain.Identity;
using HotelModels.Entities;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace HotelAPI.Application.Services
{
    public class JwtGenerator : IJwtGenerator
    {
        private JwtOptions options;

        

        public JwtGenerator(IOptions<JwtOptions> options)
        {
            this.options = options.Value ?? throw new ArgumentNullException(nameof(options));
        }

        public string GenerateToken(Customer user, IEnumerable<string> roles)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(options.Secret);

            var claimList = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Name, user.FirstName + user.LastName)
            };
            claimList.AddRange(roles.Select(x => new Claim(ClaimTypes.Role, x)));

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Audience = options.Audience,
                Issuer = options.Issuer,
                Subject = new ClaimsIdentity(claimList),
                Expires = DateTime.Now.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwt = tokenHandler.WriteToken(token);
            return jwt;

        }
    }
}

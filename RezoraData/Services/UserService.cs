using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using RezoraData.Services.Models;

namespace RezoraData.Services
{
    public interface IAPIUserService
    {
        APIUser Authenticate(string username, string password);
        IEnumerable<APIUser> GetAll();
    }

    public class APIUserService : IAPIUserService
    {
        // users hardcoded for simplicity, store in a db with hashed passwords in production applications
        private List<APIUser> _users = new List<APIUser>
        {
            new APIUser { Id = 1, FirstName = "Test", LastName = "APIUser", Username = "test", Password = "test" }
        };

        private readonly AppSettings _appSettings;

        public APIUserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public APIUser Authenticate(string username, string password)
        {
            var user = _users.SingleOrDefault(x => x.Username == username && x.Password == password);

            // return null if user not found
            if (user == null)
                return null;

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            // remove password before returning
            user.Password = null;

            return user;
        }

        public IEnumerable<APIUser> GetAll()
        {
            // return users without passwords
            return _users.Select(x => {
                x.Password = null;
                return x;
            });
        }
    }
}

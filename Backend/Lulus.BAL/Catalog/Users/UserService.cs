
using Lulus.BAL.Catalog.Users.Interfaces;
using Lulus.Data.Entities;
using Lulus.ViewModels.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;
        // Identity libaries
        public UserService(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }
        public async Task<string> Login(LoginRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.Username);
            if (user == null) return "Wrong username";
            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, false);
            if (!result.Succeeded) return "Wrong password";

            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.PrimarySid, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.MobilePhone,user.PhoneNumber),
                new Claim(ClaimTypes.Role, string.Join(";",roles))
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_configuration["Tokens:Issuer"],
                _configuration["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: creds
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public async Task<string> AdminLogin(LoginRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.Username);
            if (user == null) return "Wrong username";
            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, false);
            if (!result.Succeeded) return "Wrong password";

            var roles = await _userManager.GetRolesAsync(user);

            bool isAdmin = false;
            foreach(var item in roles)
            {
                if (item == "Admin") isAdmin = true;
            }
            if (!isAdmin) return "No permission";

            var claims = new[]
            {
                new Claim(ClaimTypes.PrimarySid, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, string.Join(";",roles))
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_configuration["Tokens:Issuer"],
                _configuration["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: creds
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public async Task<bool> Register(RegisterRequest request)
        {
            if(
                await _userManager.FindByEmailAsync(request.Email) != null ||
                await _userManager.FindByNameAsync(request.Username) != null
                )
            {
                return false;
            }
            var user = new User()
            {
                UserName = request.Username,
                Email = request.Email
            };
            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }

        public UserViewModel GetInfo(string token)
        {
            try
            {
                var stream = token;
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(stream);
                var tokenS = jsonToken as JwtSecurityToken;

                return new UserViewModel()
                {
                    ID = new Guid(tokenS.Claims.First(claim => claim.Type == ClaimTypes.PrimarySid.ToString()).Value),
                    Email = tokenS.Claims.First(claim => claim.Type == ClaimTypes.Email.ToString()).Value,
                    Username = tokenS.Claims.First(claim => claim.Type == ClaimTypes.Name.ToString()).Value,
                    Phone = tokenS.Claims.First(claim => claim.Type == ClaimTypes.MobilePhone.ToString()).Value
                };
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

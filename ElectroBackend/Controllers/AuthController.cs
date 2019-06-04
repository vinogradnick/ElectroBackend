using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ElectroBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace ElectroBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ElectroApiContext _context;

        public AuthController(ElectroApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetGuc()
        {
            return Ok(new { mes="gucci_gang" });
        }
        [HttpPost]
        public async Task<IActionResult> PostLogin(UserModel user)
        {


            if (user.Name == "admin" && user.Password == "admin")
            {
                var descr = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                       new Claim("UserID","100")
                    })
                };
           
       
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("123456789"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256Signature);

                
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(descr);
                var token = tokenHandler.WriteToken(securityToken);
                return Ok(new { token });
           
            }
           
            return BadRequest( new { message="press F" });
        }
       
    
    }
}
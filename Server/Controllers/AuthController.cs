using Accreditation_Watch.Shared.General;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Accreditation_Watch.Shared.General;

namespace Accreditation_Watch.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly DataContext _dateContext;
        private readonly IConfiguration _configuration;
        private List<User> users = new List<User>();
        public AuthController(DataContext dataContext, IConfiguration configuration)
        {
            _dateContext = dataContext;
            _configuration = configuration;
            List<User> baseUsers = new List<User>();
            //foreach (var item in _dateContext.Teachers) users.Add(item as BaseUserEntity);
            //foreach (var item in _dateContext.Parents) users.Add(item as BaseUserEntity);
        }
        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserLoginDto user)
        {
            if (user == null) return BadRequest("You need to enter valid information");
            var result = _dateContext.Users.FirstOrDefault(x => x.Email.ToLower().Trim().Equals(user.Email.ToLower().Trim()));
            if (result == null) return BadRequest("Invalid Email");
            if (!AWFunctions.VerifyPassword(user.Password, result.PasswordHash, result.PasswordSalt)) return BadRequest("Incorrect Password");
            AWFunctions.GetDeatailsFromToken(AWFunctions.CreateToken(user, result));
            return Ok(value: AWFunctions.CurrentUser.Token);
        }

        [HttpGet]
        public async Task<ActionResult<string>> LoginDemo()
        {
            var mySecret = "asdv234234^&%&^%&^hjsdfb2%%%";
            Claim claim;
            claim = new Claim(ClaimTypes.Role, "Admin");
            List<Claim> claims = new List<Claim>
            {
                //new Claim(ClaimTypes.Expiration, DateTime.Now.Add(1).Date),
                new Claim(ClaimTypes.Name, "demo"),
                new Claim(ClaimTypes.Role, "Admin"),
                new Claim(ClaimTypes.Email, "demo@cbu.com"),
                new Claim(ClaimTypes.Sid, "1")
            };
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(mySecret));
            //var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds
                );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            AWFunctions.GetDeatailsFromToken(jwt);
            return Ok(value: jwt);
        }

        [HttpGet("auto")]
        public async Task<ActionResult<string>> AutoLogin()
        {
            var accessToken = HttpContext.Request.Headers["Authorization"]
                .FirstOrDefault(h => h.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
                ?.Substring("Bearer ".Length);
            AWFunctions.GetDeatailsFromToken(accessToken);
            if (AWFunctions.CurrentUser.IsTokenExipred()) return BadRequest("Token has expired");
            if (AWFunctions.CurrentUser.Name.ToLower().Equals("demo")) return await LoginDemo();


            var user = _dateContext.Users.FirstOrDefault(x => x.Id == AWFunctions.CurrentUser.Id);
            if (user == null) return BadRequest("The token provided during auto login has been corrupted");
            AWFunctions.GetDeatailsFromToken(AWFunctions.CreateToken(user));
            //return Ok(ZambeziFunctions.CurrentUser.Token);
            return Ok(value: "trial");
        }

    }

}

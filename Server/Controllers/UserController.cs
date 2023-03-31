using Accreditation_Watch.Shared.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.X509;
using System.Numerics;
using System.Security.Policy;

namespace Accreditation_Watch.Server.Controllers
{
    public class UserController : BaseController<User, UserDto>
    {
        public UserController(DataContext dataContext) : base(dataContext) { }

        [HttpPost]
        public override async Task<ActionResult<User>> Post(UserDto newUser)
        {
            AWFunctions.CreatePasswordHash(
                newUser.Password,
                out byte[] passwordHash,
                out byte[] passwordSalt);
            User user = new()
            {
                Name = newUser.Name,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Email = newUser.Email,
                Role = _context!.Roles.FirstOrDefault(x=>(x.Id==1)),
                Token = AWFunctions.CreateToken(newUser),
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }
    }
}

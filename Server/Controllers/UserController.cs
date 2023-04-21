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
        [HttpPut("updateUserRole/")]
        public async Task<ActionResult<User>> UpdateRole(User user)
        {
            var userToUpdate = _context.Users.FirstOrDefault(x => x.Id == user.Id);
            if (userToUpdate is null) return BadRequest("User not found");
            userToUpdate.RoleId = user.RoleId;
            userToUpdate.Role = _context.Roles.FirstOrDefault(x => x.Id == user.RoleId);
            await _context.SaveChangesAsync();
            return Ok(userToUpdate);
        }
    }
}

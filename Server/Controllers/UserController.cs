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
                Role = Role.Secretary,
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
            userToUpdate.Role = user.Role;
            await _context.SaveChangesAsync();
            return Ok(userToUpdate);
        }
    }
}

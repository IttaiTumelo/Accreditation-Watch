namespace Accreditation_Watch.Shared.Entities
{
    public class User : BaseEntity
    {
        public  string Email { get; set; }
        public Role Role { get; set; }
        public string Token { get; set; }
        public byte[]? PasswordHash { get; set; } = null;
        public byte[]? PasswordSalt { get; set; } = null;
        public bool IsTokenExipred()
        {
            //Todo implement this
            return false;
        }
   

    }
    public class UserDto : User
    {
        public readonly int? Id = null;
        public string? Token { get; set; } = null;
        public byte[]? PasswordHash { get; set; } = null;
        public byte[]? PasswordSalt { get; set; } = null;
        public Role? Role { get; set; } = null;
        public string Password { get; set; }

    }
    public class UserLoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

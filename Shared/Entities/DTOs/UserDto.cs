using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accreditation_Watch.Shared.Entities.DTOs
{
    public class UserDto : User
    {
        public readonly int? Id = null;
        public string? Token { get; set; } = null;
        public byte[]? PasswordHash { get; set; } = null;
        public byte[]? PasswordSalt { get; set; } = null;
        public Role? Role { get; set; } = null;
        public string Password { get; set; }

    }
}

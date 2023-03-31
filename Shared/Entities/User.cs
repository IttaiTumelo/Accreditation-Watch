using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //if (DateTime.Now > Exipres)
            //{
            //    return true;
            //}
            return false;
        }
    }
}

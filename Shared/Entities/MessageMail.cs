using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accreditation_Watch.Shared.Entities
{
    public class MessageMail : BaseEntity
    {
        
        public List<string> Email { get; set; } = new();
        public string Message { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
    }
}

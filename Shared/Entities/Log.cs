using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accreditation_Watch.Shared.Entities
{
    public class Log : BaseEntity
    {
        public int UserId { get; set; }
        public Action Action { get; set; }
        public string Entity { get; set; }
        public int EntityId { get; set; }
        public string Description { get; set; }
    }

    public enum Action
    {
        Create,
        Update,
        Delete,
        Read, 
        Mail,
    }
}

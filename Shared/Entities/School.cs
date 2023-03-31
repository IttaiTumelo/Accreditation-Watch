using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accreditation_Watch.Shared.Entities
{
    public class School : BaseEntity
    {
        public List<Department>? Departments { get; set; } = new();
        public override List<string> RelatedEntities()
        {
            return new() { "Departments" };
        }
    }
}

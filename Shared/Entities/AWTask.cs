using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Accreditation_Watch.Shared.Entities
{
    public class AWTask : BaseEntity
    {
        public string Description { get; set; }
        public User Assignee { get; set; }
        public DateTime Due { get; set; }
        public Progress Progress { get; set; }
        public TaskType Type { get; set; }
        public AWDocument Document  { get; set; }
        public ResultType ResultType { get; set; }
    }
}

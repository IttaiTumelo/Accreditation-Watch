using Accreditation_Watch.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accreditation_Watch.Shared.Objects
{
    public class Notice : BaseEntity
    {
        public string IconeUrl;
        public bool IsAProblem { get; set; } = false;
        public List<Issue> Issues { get; set; } = new();

    }
}

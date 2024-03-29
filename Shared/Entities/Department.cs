﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accreditation_Watch.Shared.Entities
{
    public class Department : BaseEntity
    {
        public string Email { get; set; } = String.Empty;
        public int? SchoolId { get; set; }
        public School? School { get; set; }
        public List<Program>? Programs { get; set; }

        public override List<string> RelatedEntities()
        {
            return new() { "School", "Programs" };
        }
    }
    public class CreateDepartmentDto : Department
    {
        public int? Id { get; set; }
        public readonly School? School = null;
        public readonly List<Program>? Programs = new();

    }
}

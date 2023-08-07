using Accreditation_Watch.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accreditation_Watch.Shared.Objects
{
    public class Issue : BaseEntity
    {
        public string Url { get; set; }
        public DateTime? Date { get; set; }
    }
    public class Account
    {
        public int ID { get; set; }
        public double Balance { get; set; }
    }
}

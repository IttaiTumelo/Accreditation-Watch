using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accreditation_Watch.Shared.Entities
{
    public class PendingImplimentation : BaseEntity
    {
        public ProgressStatus Status { get; set; } = ProgressStatus.Pending;
    }

    public enum ProgressStatus
    {
        Pending,
        Started,
        Stopped,
        Completed,
        Researching,
        Approved
        
    }
}

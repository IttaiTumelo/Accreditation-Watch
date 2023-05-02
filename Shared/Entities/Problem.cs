using System.ComponentModel.DataAnnotations.Schema;

namespace Accreditation_Watch.Shared.Entities
{
    public  class Problem : BaseEntity
    {
        public string Description { get; set; } = string.Empty;
        public bool IsResolved { get; set; } = false;
        public Serverity Serverity { get; set; } = Serverity.Low;
        public int AWProgramId { get; set; }
        [NotMapped]
        public AWProgram? Program { get; set; } = new();
        public bool Equals(ProblemDto other)
        {
            return Description.Equals(other.Description);
        }
    }

    public class ProblemDto : Problem
    {
        public int? Id { get; } = 0;
        public readonly AWProgram? Program = null;
    }

    public enum Serverity{
        Low = 1, Medium, High, Critical
    }
    
}

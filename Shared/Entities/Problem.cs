using System.ComponentModel.DataAnnotations.Schema;

namespace Accreditation_Watch.Shared.Entities
{
    public  class Problem : BaseEntity
    {
        public string Description { get; set; } = string.Empty;
        [NotMapped]
        public string ShortDescription { get => Description?.Length > 40 ? Description.Substring(0, 40) + "..." : Description; }
        public bool IsResolved { get; set; } = false;
        public Serverity Serverity { get; set; } = Serverity.Low;
        public int AWProgramId { get; set; }
        public bool Noted { get; set; } = false;
        // [NotMapped]
        public AWProgram? Program { get; set; }
        public bool Equals(ProblemDto other)
        {
            return Description.Equals(other.Description);
        }
        public override List<string> RelatedEntities()
        {
            return new() { "Program" };
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

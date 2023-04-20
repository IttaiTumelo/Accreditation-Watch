namespace Accreditation_Watch.Shared.Entities
{
    public  class Problem : BaseEntity
    {
        public string Description { get; set; } = string.Empty;
        public bool IsResolved { get; set; } = false;
        public AWProgram? Program { get; set; }
        public bool Equals(ProblemDto other)
        {
            return base.Equals(other) &&
                Description.Equals(other.Description) &&
                IsResolved == other.IsResolved &&
                Program == other.Program;
        }
    }

    public class ProblemDto : Problem
    {
        public int? Id { get; } = 0;
        public AWProgram? Program = null;
    }
    
}

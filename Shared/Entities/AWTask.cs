using System.ComponentModel.DataAnnotations.Schema;

namespace Accreditation_Watch.Shared.Entities
{
    public class AWTask : BaseEntity
    {
        public string Description { get; set; }
        public int? AssigneeId { get; set; }
        public User? Assignee { get; set; }
        public DateTime Due { get; set; } = DateTime.Now + TimeSpan.FromDays(7);
        public Progress Progress { get; set; } = Progress.Unassigned;
        [NotMapped]
        public string ProgressString { get => Progress.ToString(); }
        public TaskType? Type { get; set; }
        public AWDocument? Document  { get; set; }
        public ResultType? ResultType { get; set; }
        public int? ProblemId { get; set; }
        public Problem? Problem { get; set; }
        public int? ProgramId { get; set; }
        public Problem? Program { get; set; }
        public int? AssignedToId { get; set; }
        public User? AssignedTo { get; set; }
        public bool IsCompleted { get; set; } = false;
        public List<Note> Notes { get; set; } = new();
        public override List<string> RelatedEntities()
        {
            return new() { "Assignee", "Type", "Document", "ResultType", "Problem", "AssignedTo", "Notes" };
        }

    }
    public class AWTaskDto : AWTask
    {
        public int? Id { get; } = 0;
        public TaskType? Type = null;
        public AWDocument? Document = null;
        public ResultType? ResultType = null;
        public Problem? Problem = null;
        public User? AssignedTo = null;
        public User? Assignee = null;
    }
    public class TaskType : BaseEntity
    {
        
    }

    public enum Progress
    {
        Unassigned = 1,
        Assigned,
        Progressing,
        Completed
    }
}

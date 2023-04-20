namespace Accreditation_Watch.Shared.Entities
{
    public class AWTask : BaseEntity
    {
        public string Description { get; set; } = string.Empty;
        public User? Assignee { get; set; }
        public DateTime Due { get; set; }
        public Progress Progress { get; set; }
        public TaskType? Type { get; set; }
        public AWDocument? Document  { get; set; }
        public ResultType? ResultType { get; set; }
        public Problem? Problem { get; set; }
        public User? AssignedTo { get; set; }
    }
    public class AWTaskDto : AWTask
    {
        public int? Id { get; } = 0;
        public User? Assignee = null;
        public TaskType? Type = null;
        public AWDocument? Document = null;
        public ResultType? ResultType = null;
        public AWProgram? Program = null;
    }
    public class TaskType : BaseEntity
    {
        
    }
}

namespace Accreditation_Watch.Shared.Entities
{
    public class Document : BaseEntity
    {
        public string Description { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Progress { get; set; }
        public string TaskType { get; set; }
        public string Role { get; set; }
        public string TaskId { get; set; }
        public string UserId { get; set; }
    }
}

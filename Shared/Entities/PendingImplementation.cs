namespace Accreditation_Watch.Shared.Entities
{
    public class PendingImplementation : BaseEntity
    {
        public ProgressStatus Status { get; set; } = ProgressStatus.Pending;
    }
    public class PendingImplementationDto : PendingImplementation
    {
        public int? Id = null;
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

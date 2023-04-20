namespace Accreditation_Watch.Shared.Entities
{
    public class PendingImplimentation : BaseEntity
    {
        public ProgressStatus Status { get; set; } = ProgressStatus.Pending;
    }
    public class PendingImplimentationDto : PendingImplimentation
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

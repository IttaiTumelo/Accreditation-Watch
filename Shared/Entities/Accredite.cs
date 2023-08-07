namespace Accreditation_Watch.Shared.Entities
{
    public class Accredite : BaseEntity
    {
        public string AccrediteName { get; set; }
        public AccrediteType Type { get; set; }
        public AccreditStatus AccreditStatus { get; set; }
        public string AccrediteDate { get; set; }
        public string AccrediteExpirationDate { get; set; }
        public string AccrediteURL { get; set; }
        public string AccrediteNotes { get; set; }
        public string AccrediteContact { get; set; }
 
    }
    public class CreateAccrediteDto : Accredite
    {
        public int? Id = null;
    }
}

namespace Accreditation_Watch.Shared.Entities 
{
    public class Reminder :BaseEntity {
        public bool FirstReminder { get; set; } = false;
        public bool SecondReminder { get; set; } = false;
        public bool ThirdReminder { get; set; } = false;
        public string Name { get; set; } = String.Empty;
        public int ProgramId { get; set; }
    }
}

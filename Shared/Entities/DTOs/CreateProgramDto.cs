namespace Accreditation_Watch.Shared.Entities.DTOs
{
    public class CreateProgramDto: AWProgram
    {
        public int Id { get; } = 0;
        public readonly Status? Status  = null;
        public readonly Department? Department = null;
        public readonly Accredite? Accredite = null;
    }
}

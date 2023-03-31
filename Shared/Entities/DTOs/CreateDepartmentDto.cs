namespace Accreditation_Watch.Shared.Entities.DTOs
{
    public class CreateDepartmentDto: Department
    {
        public int? Id { get; set; }
        public readonly School? School = null;
        public readonly List<AWProgram>? Programs = new();

    }
}

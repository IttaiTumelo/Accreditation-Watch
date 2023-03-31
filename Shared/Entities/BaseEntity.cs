global using Accreditation_Watch.Shared.Entities.DTOs;

namespace Accreditation_Watch.Shared.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<string> RelatedEntities()
        {
            return new() { };
        }

        public virtual void InitializeFromDto(BaseEntityDto dto)
        {
        }
    }
}

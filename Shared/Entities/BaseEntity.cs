using System.ComponentModel.DataAnnotations.Schema;

namespace Accreditation_Watch.Shared.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        [NotMapped]
        public string? ShortName 
        { 
            get => Name?.Length > 20 ? Name.Substring(0, 20) + "..." : Name; 
        }
         

        public virtual List<string> RelatedEntities()
        {
            return new() { };
        }

        public virtual void InitializeFromDto(BaseEntityDto dto)
        {
        }
        public virtual bool RequiresAuthentication()=>true;
        public virtual string ToString()=>Name;
    }
    public class BaseEntityDto
    {
        public string Name { get; set; }
    }

}

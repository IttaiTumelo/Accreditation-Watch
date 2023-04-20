namespace Accreditation_Watch.Shared.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public virtual List<string> RelatedEntities()
        {
            return new() { };
        }
        public virtual void InitializeFromDto(BaseEntityDto dto)
        {
        }
        public virtual bool RequiresAuthentication()=>true;
    }
    public class BaseEntityDto
    {
        public string Name { get; set; }
    }
}

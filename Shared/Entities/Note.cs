namespace Accreditation_Watch.Shared.Entities
{
     public class Note : BaseEntity
     {
           public string Content { get; set; } = string.Empty;
          public int UserId { get; set; }
          public int ProgramId { get; set; }
           public DateTime Date { get; set; } = DateTime.Now;
           public NoteState State { get; set; } = NoteState.Valid;
           public override List<string> RelatedEntities()
           {
                return new() {  };
           }
           
     }
     public class NoteDto : Note
     {
          public int? Id = null; 
     }
     public enum NoteState
     {
          Valid,
          Expired
          
     }
}
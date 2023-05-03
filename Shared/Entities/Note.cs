namespace Accreditation_Watch.Shared.Entities
{
     public class Note : BaseEntity
     {
           public string Content { get; set; } = string.Empty;
          public int UserId { get; set; }
           public DateTime Date { get; set; } = DateTime.Now;
           public NoteState State { get; set; } = NoteState.Valid;
           public List<NoteMessage> Messages { get; set; } = new();
          public int? TaskId { get; set; }
        public AWTask? Task { get; set; }
        public int? ProblemId { get; set; }
        public Problem? Problem { get; set; }
        public int? ProgramId { get; set; }
        public AWProgram? Program { get; set; }
            public int? CreatorId { get; set; }
        public User? Creator { get; set; }

        public override List<string> RelatedEntities()
        {
            return new() { "Task", "Problem", "Program", "Creator", "Messages" };
        }

           public override string ToString()
           {
               return $"{Name} \n {Content} \n by {UserId} \n for {ProgramId} \n {State} \n {Date} ";
           }
           
     }
     public class NoteMessage : BaseEntity {
          public string Content { get; set; } = string.Empty;
          public int UserId { get; set; }
          public User? User { get; set; }
          public DateTime Time { get; set; } = DateTime.Now;
          public int NoteId { get; set; }
          public Note? Note { get; set; }

          public override List<string> RelatedEntities()
          {
               return new() { "User", "Note" };
          }
     }

     public class NoteMessageDto : NoteMessage
     {
          public int? Id = null;
          public readonly User? User = null;
          public readonly Note? Note = null;
     }

     public class NoteDto : Note
     {
          public int? Id = null; 
          public readonly User? Creator = null;
     }
     public enum NoteState
     {
          Valid,
          Expired
          
     }
}
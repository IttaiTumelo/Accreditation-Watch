namespace Accreditation_Watch.Shared.Entities
{
     public class History : BaseEntity{
          public string Description {get; set;}
          public int UserId {get; set;}
          public DateTime Date {get; set;}
          public string Action {get; set;}
          public Severity Severity {get; set;}
          public string InitialState {get; set;}
          public string FinalState {get; set;}
          public string? ActionResult {get; set;}

     }

     public enum Severity
     {
          Low,
          Medium,
          High
     }
}
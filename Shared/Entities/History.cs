using System.ComponentModel.DataAnnotations.Schema;

namespace Accreditation_Watch.Shared.Entities
{
     public class History : BaseEntity{
          public string Description {get; set;}
          [NotMapped]
          public string ShortDescription {get=>Description?.Length > 40 ? Description.Substring(0, 40) + "..." : Description;}
          public int UserId {get; set;}
          public User? User {get; set;}
          public DateTime Date {get; set;}
          public string Action {get; set;}
          public Severity Severity {get; set;}
          public string InitialState {get; set;}
          public string FinalState {get; set;}
          public string? ActionResult {get; set;}

          public override List<string> RelatedEntities()
          {
               return new() { "User" };
          }

     }

     public enum Severity
     {
          Low,
          Medium,
          High
     }
}
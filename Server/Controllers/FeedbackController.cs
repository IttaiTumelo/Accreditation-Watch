using Microsoft.AspNetCore.Mvc;

namespace Accreditation_Watch.Server.Controllers
{
   public class FeedbackController : BaseController<Feedback, BaseEntity>
   {
       public FeedbackController(DataContext dataContext) : base(dataContext) { }

   }
}

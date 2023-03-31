using Microsoft.AspNetCore.Mvc;

namespace Accreditation_Watch.Server.Controllers
{
   public class AccrediteController : BaseController<Accredite, CreateAccrediteDto>
   {
       public AccrediteController(DataContext dataContext) : base(dataContext) { }

   }
}

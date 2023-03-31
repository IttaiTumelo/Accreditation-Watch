using Microsoft.AspNetCore.Mvc;

namespace Accreditation_Watch.Server.Controllers
{
   public class AWProgramController : BaseController<AWProgram, CreateProgramDto>
   {
       public AWProgramController(DataContext dataContext) : base(dataContext) { }

   }
}

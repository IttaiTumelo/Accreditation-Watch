using Microsoft.AspNetCore.Mvc;

namespace Accreditation_Watch.Server.Controllers
{
   public class SchoolController : BaseController<School, CreateSchoolDto>
   {
       public SchoolController(DataContext dataContext) : base(dataContext) { }

   }
}

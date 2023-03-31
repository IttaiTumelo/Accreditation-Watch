using Microsoft.AspNetCore.Mvc;

namespace Accreditation_Watch.Server.Controllers
{
   public class DepartmentController : BaseController<Department, CreateDepartmentDto>
   {
       public DepartmentController(DataContext dataContext) : base(dataContext) { }

   }
}

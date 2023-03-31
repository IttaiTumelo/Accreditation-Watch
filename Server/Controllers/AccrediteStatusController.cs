using Microsoft.AspNetCore.Mvc;

namespace Accreditation_Watch.Server.Controllers
{
    public class AccrediteStatusController : BaseController<AccrediteStatus, AccrediteStatus>
    {
        public AccrediteStatusController(DataContext dataContext) : base(dataContext) { }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace Accreditation_Watch.Server.Controllers
{
    public class PendingImplimentationController : BaseController<PendingImplimentation, PendingImplimentationDto>
    {
        public PendingImplimentationController(DataContext dataContext) : base(dataContext) { }
    }
}

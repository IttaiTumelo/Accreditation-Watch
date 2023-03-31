namespace Accreditation_Watch.Server.Controllers
{
        public class HistoryController : BaseController<History, History>
   {
       public HistoryController(DataContext dataContext) : base(dataContext) { }

   }
}
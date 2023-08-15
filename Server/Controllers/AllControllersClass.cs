namespace Accreditation_Watch.Server.Controllers
{
    using Program=Shared.Entities.Program;
    using Task=Shared.Entities.Task;

    public class AccreditController : BaseController<Accredite, CreateAccrediteDto>
    {
        public AccreditController(DataContext dataContext) : base(dataContext) { }
    }
    public class AccreditStatusController : BaseController<AccreditStatus, AccreditStatus>
    {
        public AccreditStatusController(DataContext dataContext) : base(dataContext) { }
    }
    public class programController : BaseController<Program, CreateProgramDto>
    {
        public programController(DataContext dataContext) : base(dataContext) { }
        
        [HttpGet]
        public override async Task<ActionResult<IEnumerable<Program>>> Get() => await _context.Programs.Include(p => p.Department).ThenInclude(d=>d.School ).ToListAsync();
          

    }
    public class DepartmentController : BaseController<Department, CreateDepartmentDto>
    {
        public DepartmentController(DataContext dataContext) : base(dataContext) { }
    }
    public class FeedbackController : BaseController<Feedback, BaseEntity>
    {
        public FeedbackController(DataContext dataContext) : base(dataContext) { }
    }
    public class HistoryController : BaseController<History, History>
    {
        public HistoryController(DataContext dataContext) : base(dataContext) { }
    }
    // public class PendingImplimentationController : BaseController<PendingImplementation, PendingImplementationDto>
    // {
    //     public PendingImplimentationController(DataContext dataContext) : base(dataContext) { }
    // }
    public class SchoolController : BaseController<School, CreateSchoolDto>
    {
        public SchoolController(DataContext dataContext) : base(dataContext) { }
    }
    //deprecated replaced by AWTasks
    public class TaskController : BaseController<Task, TaskDto>
    {
        public TaskController(DataContext dataContext) : base(dataContext) { }
    }
    public class ProblemController : BaseController<Problem, ProblemDto>
    {
        public ProblemController(DataContext dataContext) : base(dataContext) { }
    }
    public class AWTaskController : BaseController<Task, TaskDto>
    {
        public AWTaskController(DataContext dataContext) : base(dataContext) { }
    }
    public class NoteController : BaseController<Note, NoteDto>
    {
        public NoteController(DataContext dataContext) : base(dataContext) { }
    }
    public class NoteMessageController : BaseController<NoteMessage, NoteMessageDto>
    {
        public NoteMessageController(DataContext dataContext) : base(dataContext) { }
    }
    
    
    public class ReminderController : BaseController<Reminder, Reminder>
    {
        public ReminderController(DataContext dataContext) : base(dataContext) { }
    }
}

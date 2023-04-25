namespace Accreditation_Watch.Server.Controllers
{
    public class AccrediteController : BaseController<Accredite, CreateAccrediteDto>
    {
        public AccrediteController(DataContext dataContext) : base(dataContext) { }
    }
    public class AccrediteStatusController : BaseController<AccrediteStatus, AccrediteStatus>
    {
        public AccrediteStatusController(DataContext dataContext) : base(dataContext) { }
    }
    public class AWProgramController : BaseController<AWProgram, CreateProgramDto>
    {
        public AWProgramController(DataContext dataContext) : base(dataContext) { }
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
    // public class PendingImplimentationController : BaseController<PendingImplimentation, PendingImplimentationDto>
    // {
    //     public PendingImplimentationController(DataContext dataContext) : base(dataContext) { }
    // }
    public class SchoolController : BaseController<School, CreateSchoolDto>
    {
        public SchoolController(DataContext dataContext) : base(dataContext) { }
    }
    //deprecated replaced by AWTasks
    public class TaskController : BaseController<AWTask, AWTaskDto>
    {
        public TaskController(DataContext dataContext) : base(dataContext) { }
    }
    public class ProblemController : BaseController<Problem, ProblemDto>
    {
        public ProblemController(DataContext dataContext) : base(dataContext) { }
    }
    public class AWTaskController : BaseController<AWTask, AWTaskDto>
    {
        public AWTaskController(DataContext dataContext) : base(dataContext) { }
    }
    public class NoteController : BaseController<Note, NoteDto>
    {
        public NoteController(DataContext dataContext) : base(dataContext) { }
    }
}

namespace Accreditation_Watch.Client.Services.Contracts
{
    using Program=Accreditation_Watch.Shared.Entities.Program;
    using Task=Accreditation_Watch.Shared.Entities.Task;

    public interface IAccrediteService : IBaseService<Accredite>{}
    public interface IAccrediteStatusService : IBaseService<AccreditStatus>{}
    public interface IDepartmentService : IBaseService<Department>{}
    public interface IHistoryService : IBaseService<History>{}
    public interface IPendingImplimentationService : IBaseService<PendingImplementation>{}

    public interface IProgramService : IBaseService<Program>
    {
        Task<List<Program>> Get(Degree degree = Degree.Unset);
    }
    public interface IUserService : IBaseService<User>
    {
        Task<User> Create(UserDto dto);
        Task<User> UpdateRole(User dto);
        Task<Boolean> CheckUsers();
    }
    public interface ISchoolService : IBaseService<School> { }
    public interface IAWTaskService : IBaseService<Task> { }
    public interface IProblemService : IBaseService<Problem> { }
    public interface INoteService : IBaseService<Note> { 
        List<Note> Dismissed { get; }
        List<Note> Active { get; }
    }
    public interface INoteMessageService : IBaseService<NoteMessage> { }
    
}

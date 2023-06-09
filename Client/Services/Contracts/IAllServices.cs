﻿namespace Accreditation_Watch.Client.Services.Contracts
{
    public interface IAccrediteService : IBaseService<Accredite>{}
    public interface IAccrediteStatusService : IBaseService<AccrediteStatus>{}
    public interface IDepartmentService : IBaseService<Department>{}
    public interface IHistoryService : IBaseService<History>{}
    public interface IPendingImplimentationService : IBaseService<PendingImplimentation>{}
    public interface IProgramService : IBaseService<AWProgram>{}
    public interface IUserService : IBaseService<User>
    {
        Task<User> Create(UserDto dto);
        Task<User> UpdateRole(User dto);
    }
    public interface ISchoolService : IBaseService<School> { }
    public interface IAWTaskService : IBaseService<AWTask> { }
    public interface IProblemService : IBaseService<Problem> { }
    public interface INoteService : IBaseService<Note> { 
        List<Note> Dismissed { get; }
        List<Note> Active { get; }
    }
    public interface INoteMessageService : IBaseService<NoteMessage> { }
}

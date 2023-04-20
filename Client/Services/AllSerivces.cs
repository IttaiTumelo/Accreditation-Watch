namespace Accreditation_Watch.Client.Services
{
    public class AccrediteService : BaseService<Accredite>, IAccrediteService
    {
        public AccrediteService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
    public class AccrediteStatusService : BaseService<AccrediteStatus>, IAccrediteStatusService
    {
        public AccrediteStatusService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
    public class DepartmentService : BaseService<Department>, IDepartmentService
    {
        public DepartmentService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
    public class HistoryService : BaseService<History>, IHistoryService
    {
        public HistoryService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
    public class PendingImplimentationService : BaseService<PendingImplimentation>, IPendingImplimentationService
    {
        public PendingImplimentationService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
    public class ProgramService : BaseService<AWProgram>, IProgramService
    {
        public ProgramService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
    public class SchoolService : BaseService<School>, ISchoolService
    {
        public SchoolService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
    public class RoleService : BaseService<Role>, IRoleService
    {
        public RoleService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
    public class AWTaskService : BaseService<AWTask>, IAWTaskService
    {
        public AWTaskService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
    public class ProblemService : BaseService<Problem>, IProblemService
    {
        public ProblemService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}

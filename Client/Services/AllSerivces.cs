namespace Accreditation_Watch.Client.Services
{
    using Program=Accreditation_Watch.Shared.Entities.Program;
    using Task=Accreditation_Watch.Shared.Entities.Task;

    public class AccrediteService : BaseService<Accredite>, IAccrediteService
    {
        public AccrediteService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
    public class AccrediteStatusService : BaseService<AccreditStatus>, IAccrediteStatusService
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
    public class PendingImplimentationService : BaseService<PendingImplementation>, IPendingImplimentationService
    {
        public PendingImplimentationService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
    public class ProgramService : BaseService<Program>, IProgramService
    {
        public ProgramService(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<List<Program>> Get(Degree degree = Degree.Unset)
        {
            if(Objects.Count == 0)
            {
                var request = await HttpClient.GetAsync($"api/Program");
                if (!request.IsSuccessStatusCode) throw new Exception(request.ReasonPhrase);
                var objects = await request.Content.ReadFromJsonAsync<List<Program>>();
                Objects = objects ?? throw new Exception("No objects were found");
            }
            
            return degree == Degree.Unset? Objects : Objects.Where(obj => obj.Degree == degree).ToList();
        }
    }
    public class SchoolService : BaseService<School>, ISchoolService
    {
        public SchoolService(HttpClient httpClient) : base(httpClient)
        {
        }
    }

    public class AWTaskService : BaseService<Task>, IAWTaskService
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
    public class NoteService : BaseService<Note>, INoteService
    {
        public NoteService(HttpClient httpClient) : base(httpClient)
        {
        }

          public List<Note> Dismissed { get => Objects?.Where(x => x.State == NoteState.Expired)?.ToList(); }
          public List<Note> Active {  get=> Objects?.Where(x => x.State == NoteState.Valid)?.ToList();}
     }
    public class NoteMessageService : BaseService<NoteMessage>, INoteMessageService
    {
        public NoteMessageService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}

namespace Accreditation_Watch.Client.Services
{
     //public class ProgramService : BaseService<AWProgram, CreateProgramDto>, IProgramService
     public class ProgramService : BaseService<AWProgram>, IProgramService
     {
        public ProgramService(HttpClient httpClient) : base(httpClient)
        {
        }

    }

}
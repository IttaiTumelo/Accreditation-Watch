namespace Accreditation_Watch.Client.Services
{
     //public class SchoolService : BaseService<School, CreateSchoolDto>, ISchoolService
     public class SchoolService : BaseService<School>, ISchoolService
     {
          public SchoolService(HttpClient httpClient) : base(httpClient)
          {
          }
     }

}
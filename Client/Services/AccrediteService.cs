namespace Accreditation_Watch.Client.Services
{
     //public class AccrediteService : BaseService<Accredite, BaseEntityDto>, IAccrediteService
     public class AccrediteService : BaseService<Accredite>, IAccrediteService
     {
          public AccrediteService(HttpClient httpClient) : base(httpClient)
          {
          }
     }

}
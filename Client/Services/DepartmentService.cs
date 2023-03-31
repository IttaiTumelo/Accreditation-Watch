namespace Accreditation_Watch.Client.Services
{
     //public class DepartmentService : BaseService<Department, CreateDepartmentDto>, IDepartmentService
     public class DepartmentService : BaseService<Department>, IDepartmentService
     {
          public DepartmentService(HttpClient httpClient) : base(httpClient)
          {
          }
     }

}
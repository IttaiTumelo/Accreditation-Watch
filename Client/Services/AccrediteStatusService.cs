namespace Accreditation_Watch.Client.Services
{
    public class AccrediteStatusService : BaseService<AccrediteStatus>, IAccrediteStatusService
    {
        public AccrediteStatusService(HttpClient httpClient) : base(httpClient)
        {
        }
    
    }
}

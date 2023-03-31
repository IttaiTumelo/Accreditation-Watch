namespace Accreditation_Watch.Client.Services
{
    public class PendingImplimentationService : BaseService<PendingImplimentation>, IPendingImplimentationService
    {
        public PendingImplimentationService(HttpClient httpClient) : base(httpClient)
        {
        }
    }

}

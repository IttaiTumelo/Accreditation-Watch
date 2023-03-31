namespace Accreditation_Watch.Client.Services
{
    public class HistoryService : BaseService<History>, IHistoryService
    {
            public HistoryService(HttpClient httpClient) : base(httpClient)
            {
            }

    }
}
using System.Net.Http;

namespace Accreditation_Watch.Client.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly HttpClient _httpClient;
        public UserService(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<User> Create(UserDto dto)
        {
            var request = await _httpClient.PostAsJsonAsync<UserDto>($"api/{typeof(User).Name}", dto);
            if (request.IsSuccessStatusCode)
            {
                var response = await request.Content.ReadFromJsonAsync<User>();
                if (response != null)
                {
                    Objects.Add(response);
                    return response;
                }
                else return null;
            }
            else
            {
                throw new Exception(request.ReasonPhrase);
            }
        }
    }
}

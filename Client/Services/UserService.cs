using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace Accreditation_Watch.Client.Services
{
    using Task=System.Threading.Tasks.Task;

    public class UserService : BaseService<User>, IUserService
    {
        private readonly HttpClient _httpClient;
        public UserService(HttpClient httpClient, NavigationManager navigationManager ) : base(httpClient, navigationManager)
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

          public async Task<User> UpdateRole(User dto)
          {
                var request = await _httpClient.PutAsJsonAsync<User>($"api/{typeof(User).Name}/updateUserRole", dto);
                if (request.IsSuccessStatusCode)
                {
                    var response = request.Content.ReadFromJsonAsync<User>().Result;
                    if (response != null)
                    {
                        Objects.Remove(Objects.First(o => o.Id == response.Id));
                        Objects.Add(response);
                        return response;
                    }
                    else throw new Exception($"Could no update user role for user with id {dto.Id}");
                }
                else
                {
                    throw new Exception(request.ReasonPhrase);
                }
          }

          public async Task<Boolean> CheckUsers()
          {
                var request = await _httpClient.GetAsync($"api/{typeof(User).Name}/CheckUsers");
                if (request.IsSuccessStatusCode)
                {
                    var response = await request.Content.ReadFromJsonAsync<Boolean>();
                    return response;
                }
                else
                {
                    throw new Exception(request.ReasonPhrase);
                }
          }
    }
}

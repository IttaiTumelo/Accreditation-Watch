global using Accreditation_Watch.Client.Services.Contracts;
global using System.Net.Http.Json;
using Microsoft.IdentityModel.Tokens;

namespace Accreditation_Watch.Client.Services
{
    //public class BaseService<T, TDto> : IBaseService<T, TDto> where T : BaseEntity where TDto : BaseEntityDto
    public class BaseService<T> : IBaseService<T> where T : BaseEntity, new()
    {
        private readonly HttpClient _httpClient;
        public BaseService(HttpClient httpClient) => _httpClient = httpClient;

        public List<T> Objects { get; set; } = new();
        public T Object { get; set; } = new();

        public virtual async Task<T> Create(T dto)
        {
            var request = await _httpClient.PostAsJsonAsync<T>($"api/{typeof(T).Name}", dto);
            if (!request.IsSuccessStatusCode) throw new Exception($"Creating {typeof(T).Name} returned {request.StatusCode}");
            var response = await request.Content.ReadFromJsonAsync<T>();
            if (response is null) throw new Exception($"Creating {typeof(T).Name} returned is null");
            Object = response;
            Objects.Add(Object);
            return response;
        }

        public virtual async Task<T> Delete(int id)
        {
            var request = await _httpClient.DeleteAsync($"api/{typeof(T).Name}/{id}");
            if (!request.IsSuccessStatusCode) throw new Exception(request.ReasonPhrase);
            var response = await request.Content.ReadFromJsonAsync<T>();
            if (response == null) throw new Exception("No object was deleted");
            Objects.Remove(Objects.First(o=>o.Id==id));
            return response;
        }

        public virtual async Task<List<T>> Get()
        {
            var request = await _httpClient.GetAsync($"api/{typeof(T).Name}");
            if (!request.IsSuccessStatusCode) throw new Exception(request.ReasonPhrase);
            var objects = request.Content.ReadFromJsonAsync<List<T>>().Result;
            if (objects is null) throw new Exception("No objects were found");
            Objects = objects;
            return Objects;
        }

        public virtual async Task<T> GetByID(int id)
        {
            var request = await _httpClient.GetAsync($"api/{typeof(T).Name}/{id}");
            if (!request.IsSuccessStatusCode) throw new Exception(request.ReasonPhrase);
            var response = await request.Content.ReadFromJsonAsync<T>();
            if (response is null) throw new Exception("No object was found");
            Object = response;
            return Object;
        }

        public virtual async Task<T> Update(T t)
        {
            var request = await _httpClient.PutAsJsonAsync<T>($"api/{typeof(T).Name}", t);
            if (!request.IsSuccessStatusCode) throw new Exception(request.ReasonPhrase);
            var response = await request.Content.ReadFromJsonAsync<T>();
            if (response is null) throw new Exception("No object was updated");
            return response;
        }
    }
}
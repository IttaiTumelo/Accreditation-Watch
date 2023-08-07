namespace Accreditation_Watch.Client.Services.Contracts
{
     //public interface IBaseService<T, TDto> where T : BaseEntity where TDto : BaseEntityDto
     public interface IBaseService<T> where T : BaseEntity
     {
        List<T> Objects { get; set; }
        T Object { get; set; }
        // Task<List<T>> Get(bool forceRefresh = false, int id = 0, Degree degree = Degree.Unset );
        Task<List<T>> Get(bool forceRefresh = false, int id = 0, string name = "");
        Task<T> Create(T dto);
        Task<T> Update(T t);
        Task<T> Delete(int id);
     }
     
}


/******
 *
 *
 * 
        public async Task<List<T>> Get(bool forceRefresh = false, int id = 0, Degree degree = Degree.Unset)
        {
            if (forceRefresh is false)
            {
                if (Objects is not null && Objects.Count > 0)
                {
                    if (id != 0)
                    {
                        Object = Objects.FirstOrDefault(obj => obj.Id == id);
                        if(Object is null) throw new Exception("File not found, try refreshing the page");
                        return new List<T>() { Object };
                    }else if (degree != Degree.Unset)
                    {
                        var objs = Objects.Where(obj => obj.Degree == degree).ToList();
                        if(objs.Count == 0) throw new Exception("No objects were found");
                        return objs;
                    }
                    else
                    {
                        return Objects;
                    }
                    
                }
            }
            else
            {
                if (id != 0)
                {
                    var result = await _httpClient.GetAsync($"api/{typeof(T).Name}/{id}");
                    if(!result.IsSuccessStatusCode) throw new Exception(result.ReasonPhrase);
                    var obj = await result.Content.ReadFromJsonAsync<T>();
                    if(obj is null) throw new Exception("No object was found");
                    Object = obj;
                    return new() { obj };
                }
                else
                {
                    var request = await _httpClient.GetAsync($"api/{typeof(T).Name}");

                }
            }
            if (Objects is not null)
            {
                if (forceRefresh) Objects.Clear();
                if(Objects.Count > 0) return Objects; // TODO: Add a check for if the objects are up to date (last updated
            }
            if (!request.IsSuccessStatusCode) throw new Exception(request.ReasonPhrase);
            var objects = request.Content.ReadFromJsonAsync<List<T>>().Result;
            if (objects is null) throw new Exception("No objects were found");
            Objects = objects;
            return objects;
        }
****/
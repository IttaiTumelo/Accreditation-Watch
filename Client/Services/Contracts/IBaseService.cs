namespace Accreditation_Watch.Client.Services.Contracts
{
     //public interface IBaseService<T, TDto> where T : BaseEntity where TDto : BaseEntityDto
     public interface IBaseService<T> where T : BaseEntity
     {
        List<T> Objects { get; set; }
        T Object { get; set; }
        Task<List<T>> Get();
        Task<List<T>> Get(bool forceRefresh);
        Task<T> GetByID(int id);
        Task<T> Create(T dto);
        Task<T> Update(T t);
        Task<T> Delete(int id);
     }
}
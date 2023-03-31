namespace Accreditation_Watch.Client.Services.Contracts
{
    public interface IUserService : IBaseService<User>
    {
        Task<User> Create(UserDto dto);
    }

}

namespace Accreditation_Watch.Client.Services.Contracts
{
    using Task=System.Threading.Tasks.Task;

    public interface IAuthService
    {
        Task<string> LogIn(UserLoginDto user);
        Task<string> LogOut();
        Task<bool> IsInRole(string role);
        Task<List<string>> WhatRoles();
        Task InitialiseAuthState();
        Task<int> GetId();
        Task<bool> AutoLogin();
    }
}

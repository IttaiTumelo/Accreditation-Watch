namespace Accreditation_Watch.Client.Services.Contracts
{
    public interface IAuthService
    {
        Task<string> LogIn(UserLoginDto user);
        Task<string> LogInDemo();
        Task<string> LogOut();
        Task<bool> IsInRole(string role);
        Task<List<string>> WhatRoles();
        Task InitialiseAuthState();
        Task<int> GetId();
        Task<bool> AutoLogin();
    }
}

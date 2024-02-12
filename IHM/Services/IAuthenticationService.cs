using IHM.Dtos;
using IHM.Models;

namespace IHM.Services
{
    public interface IAuthenticationService
    {
        Task<AuthenticationStatus> RegisterAsync(RegisterDto  registerDto);
        Task<AuthenticationStatus> LoginAsync(LoginDto loginDto);
        Task LogoutAsync();
    }
}

using WinFormsApp.Entities;

namespace WinFormsApp.Interfaces.Services;

public interface IUserService
{
    Task AddUserAsync(AppUser user);
    Task<bool> UserExists(string username);
    Task<AppUser?> GetUserByUsername(string username);
}

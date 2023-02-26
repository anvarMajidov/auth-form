using WinFormsApp.Entities;

namespace WinFormsApp.Interfaces.Repositories;

public interface IUserRepository
{
    Task AddUserAsync(AppUser user);
    Task<AppUser?> GetUserByUsernameAsync(string username);
    Task<IReadOnlyList<AppUser>> GetUsersAsync();
}

using WinFormsApp.Entities;
using WinFormsApp.Interfaces.Repositories;
using WinFormsApp.Interfaces.Services;

namespace WinFormsApp.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;
    private readonly IPasswordHashService _passwordHashService;

    public UserService(IUserRepository repository, IPasswordHashService passwordHashService)
    {
        _repository = repository;
        _passwordHashService = passwordHashService;
    }

    public async Task AddUserAsync(AppUser user)
    {
        user.Password = _passwordHashService.HashPassword(user.Password);
        await _repository.AddUserAsync(user);
    }

    public async Task<bool> UserExists(string username)
    {
        var user = await _repository.GetUserByUsernameAsync(username);

        if (user != null) { return true; }
        return false;
    }

    public async Task<AppUser?> GetUserByUsername(string username)
    {
        return await _repository.GetUserByUsernameAsync(username);
    }
}
using Microsoft.EntityFrameworkCore;
using WinFormsApp.Data;
using WinFormsApp.Entities;
using WinFormsApp.Interfaces.Repositories;

namespace WinFormsApp.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddUserAsync(AppUser user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    public async Task<AppUser?> GetUserByUsernameAsync(string username)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
    }

    public async Task<IReadOnlyList<AppUser>> GetUsersAsync()
    {
        return await _context.Users.ToListAsync();
    }
}

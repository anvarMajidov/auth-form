using Microsoft.Extensions.DependencyInjection;
using WinFormsApp.Data;
using WinFormsApp.Forms;
using WinFormsApp.Interfaces.Repositories;
using WinFormsApp.Interfaces.Services;
using WinFormsApp.Repositories;
using WinFormsApp.Services;

namespace WinFormsApp;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        
        var services = new ServiceCollection();
        ConfigureServices(services);

        using var client = new AppDbContext();
        client.Database.EnsureCreated();

        using var serviceProvider = services.BuildServiceProvider();
        var mainForm = serviceProvider.GetRequiredService<Login>();
        
        Application.Run(mainForm);
    }
    
    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddEntityFrameworkSqlite()
            .AddDbContext<AppDbContext>();

        services.AddScoped<Login>();
        services.AddScoped<Register>();
        services.AddScoped<Home>();

        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IPasswordHashService, PasswordHashService>();
        services.AddScoped<IUserRepository, UserRepository>();
    }
}

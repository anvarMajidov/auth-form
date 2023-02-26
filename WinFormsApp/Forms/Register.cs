using WinFormsApp.Entities;
using WinFormsApp.Helpers;
using WinFormsApp.Interfaces.Services;

namespace WinFormsApp.Forms;

public partial class Register : Form
{
    private bool isPasswordVisible = true;
    private bool isPasswordVerifyVisible = true;

    private readonly Login _login;
    private readonly IUserService _userService;

    public Register(Login login, IUserService userService)
    {
        _login = login;
        _userService = userService;

        InitializeComponent();

        MaximizeBox = false;
        MinimizeBox = false;
    }

    private async void registerBtn_ClickAsync(object sender, EventArgs e)
    {
        var username = usernameField.Text.Trim();
        var password = passwordField.Text;
        var passwordVerify = passwordVerifyField.Text;
        
        if (!FieldValidator.IsUsernameValid(username) || 
            !FieldValidator.IsPasswordValid(password) ||
            !FieldValidator.DoPasswordsMatch(password, passwordVerify)) 
        {
            return;
        }

        if (await _userService.UserExists(username))
        {
            MessageBox.Show("Username already taken");
            return;
        }

        await _userService.AddUserAsync(new AppUser {
            Username = username, 
            Password = password 
        });

        _login.UpdateLoginFields(username, password);

        Hide();
        _login.Show();
    }

    private void showHideBtn_Click(object sender, EventArgs e)
    {
        isPasswordVisible = !isPasswordVisible;

        passwordField.PasswordChar = !isPasswordVisible ? '•' : '\0';
    }

    private void showHide2Btn_Click(object sender, EventArgs e)
    {
        isPasswordVerifyVisible = !isPasswordVerifyVisible;

        passwordVerifyField.PasswordChar = !isPasswordVerifyVisible ? '•' : '\0';
    }
}

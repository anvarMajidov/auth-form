using WinFormsApp.Helpers;
using WinFormsApp.Interfaces.Services;

namespace WinFormsApp.Forms;

public partial class Login : Form
{
    private bool isPasswordVisible = true;
    private const string UserFilename = "user.txt";

    private readonly Home _home;
    private readonly IUserService _userService;
    private readonly IPasswordHashService _passwordHashService;

    public Login(Home home, IUserService userService, IPasswordHashService passwordHashService)
    {
        _home = home;
        _userService = userService;
        _passwordHashService = passwordHashService;

        InitializeComponent();
        InitializeFields();

        FormBorderStyle = FormBorderStyle.FixedSingle; // Disable resizing
        MaximizeBox = false;
        MinimizeBox = false;
    }

    private async void LoginBtn_Click(object sender, EventArgs e)
    {
        string username = usernameField.Text.Trim();
        string password = passwordField.Text;

        if(!FieldValidator.IsUsernameValid(username) || !FieldValidator.IsPasswordValid(password))
        {
            return;
        }
        
        UpdateCheckbox(username, password);

        var user = await _userService.GetUserByUsername(username);
        if(user == null)
        {
            MessageBox.Show("Username not found");
            return;
        }

        if(!_passwordHashService.VerifyPassword(password, user.Password))
        {
            MessageBox.Show("Password is incorrect");
            return;
        }

        Hide();
        _home.Show();
    }

    private void showHideBtn_Click(object sender, EventArgs e)
    {
        isPasswordVisible = !isPasswordVisible;

        passwordField.PasswordChar = !isPasswordVisible ? '•' : '\0';
    }


    private void registerBtn_Click(object sender, EventArgs e)
    {
        var register = new Register(this, _userService);
        Hide();
        register.Show();
    }

    public void UpdateLoginFields(string username, string password)
    {
        usernameField.Text = username;
        passwordField.Text = password;
    }

    private void UpdateCheckbox(string username, string password)
    {
        if (rememberCheckBox.Checked)
        {
            File.WriteAllLines(UserFilename, new[] { username, password });
        }
        else
        {
            File.Delete(UserFilename);
        }
    }

    private void InitializeFields()
    {
        if (File.Exists(UserFilename))
        {
            var userLines = File.ReadAllLines(UserFilename);
            if (userLines.Length == 2)
            {
                usernameField.Text = userLines[0];
                passwordField.Text = userLines[1];
                rememberCheckBox.Checked = true;
            }
        }
    }
}

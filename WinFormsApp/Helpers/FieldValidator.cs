using System.Text.RegularExpressions;

namespace WinFormsApp.Helpers;

public static class FieldValidator
{
    public static bool IsUsernameValid(string username)
    {
        if (string.IsNullOrEmpty(username))
        {
            MessageBox.Show("Please enter a username.");
            return false;
        }

        var regex = new Regex(@"^[a-zA-Zа-яА-Я]+$");
        if (!regex.IsMatch(username))
        {
            MessageBox.Show("Username must contain only cyrillic or latin letters");
            return false;
        }

        if (username.Length < 8)
        {
            MessageBox.Show("Username must be at least 8 characters long.");
            return false;
        }
        return true;
    }

    public static bool IsPasswordValid(string password)
    {
        if (string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please enter a password.");
            return false;
        }

        if (password.Length < 8)
        {
            MessageBox.Show("Password must be at least 8 characters long.");
            return false;
        }
        return true;
    }

    public static bool DoPasswordsMatch(string p1, string p2)
    {
        if (p1.Equals(p2)) return true;
        
        MessageBox.Show("Passwords do not match");
        
        return false;
    }
}
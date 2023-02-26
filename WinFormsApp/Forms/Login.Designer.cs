using System.ComponentModel;

namespace WinFormsApp.Forms
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            registerBtn = new Button();
            LoginBtn = new Button();
            passwordField = new TextBox();
            usernameField = new TextBox();
            rememberCheckBox = new CheckBox();
            passwordLabel = new Label();
            usernameLabel = new Label();
            titleLabel = new Label();
            showHideBtn = new Button();
            SuspendLayout();
            // 
            // registerBtn
            // 
            registerBtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            registerBtn.Location = new Point(98, 501);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(284, 54);
            registerBtn.TabIndex = 23;
            registerBtn.Text = "Регистрироваться";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Transparent;
            LoginBtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.Location = new Point(98, 404);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(284, 49);
            LoginBtn.TabIndex = 22;
            LoginBtn.Text = "Войти";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // passwordField
            // 
            passwordField.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            passwordField.Location = new Point(98, 295);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(245, 32);
            passwordField.TabIndex = 21;
            // 
            // usernameField
            // 
            usernameField.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            usernameField.Location = new Point(98, 206);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(284, 32);
            usernameField.TabIndex = 20;
            // 
            // rememberCheckBox
            // 
            rememberCheckBox.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rememberCheckBox.Location = new Point(98, 355);
            rememberCheckBox.Name = "rememberCheckBox";
            rememberCheckBox.Size = new Size(284, 24);
            rememberCheckBox.TabIndex = 19;
            rememberCheckBox.Text = "Remember me";
            rememberCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordLabel
            // 
            passwordLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(98, 260);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(284, 23);
            passwordLabel.TabIndex = 18;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(98, 167);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(284, 23);
            usernameLabel.TabIndex = 17;
            usernameLabel.Text = "Username";
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(98, 107);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(284, 35);
            titleLabel.TabIndex = 16;
            titleLabel.Text = "LOGIN";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // showHideBtn
            // 
            showHideBtn.BackColor = Color.Transparent;
            showHideBtn.BackgroundImage = Properties.Resources.hide_svgrepo_com;
            showHideBtn.BackgroundImageLayout = ImageLayout.Zoom;
            showHideBtn.FlatAppearance.BorderSize = 0;
            showHideBtn.FlatStyle = FlatStyle.Flat;
            showHideBtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            showHideBtn.Location = new Point(349, 295);
            showHideBtn.Name = "showHideBtn";
            showHideBtn.Size = new Size(33, 32);
            showHideBtn.TabIndex = 24;
            showHideBtn.UseVisualStyleBackColor = false;
            showHideBtn.Click += showHideBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 649);
            Controls.Add(showHideBtn);
            Controls.Add(registerBtn);
            Controls.Add(LoginBtn);
            Controls.Add(passwordField);
            Controls.Add(usernameField);
            Controls.Add(rememberCheckBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(titleLabel);
            Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.CheckBox rememberCheckBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label titleLabel;

        #endregion

        private Button showHideBtn;
    }
}
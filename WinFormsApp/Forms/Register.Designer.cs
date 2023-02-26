using System.ComponentModel;

namespace WinFormsApp.Forms
{
    partial class Register
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
            passwordVerifyField = new TextBox();
            passwordVerifyLabel = new Label();
            registerBtn = new Button();
            passwordField = new TextBox();
            usernameField = new TextBox();
            passwordLabel = new Label();
            usernameLabel = new Label();
            titleLabel = new Label();
            showHideBtn = new Button();
            showHide2Btn = new Button();
            SuspendLayout();
            // 
            // passwordVerifyField
            // 
            passwordVerifyField.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            passwordVerifyField.Location = new Point(77, 408);
            passwordVerifyField.Margin = new Padding(4);
            passwordVerifyField.Name = "passwordVerifyField";
            passwordVerifyField.Size = new Size(261, 32);
            passwordVerifyField.TabIndex = 25;
            // 
            // passwordVerifyLabel
            // 
            passwordVerifyLabel.Location = new Point(77, 372);
            passwordVerifyLabel.Margin = new Padding(4, 0, 4, 0);
            passwordVerifyLabel.Name = "passwordVerifyLabel";
            passwordVerifyLabel.Size = new Size(302, 32);
            passwordVerifyLabel.TabIndex = 24;
            passwordVerifyLabel.Text = "Подтвердите пароль";
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(77, 469);
            registerBtn.Margin = new Padding(4);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(302, 56);
            registerBtn.TabIndex = 23;
            registerBtn.Text = "Регистрироваться";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_ClickAsync;
            // 
            // passwordField
            // 
            passwordField.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            passwordField.Location = new Point(77, 309);
            passwordField.Margin = new Padding(4);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(261, 32);
            passwordField.TabIndex = 22;
            // 
            // usernameField
            // 
            usernameField.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            usernameField.Location = new Point(77, 222);
            usernameField.Margin = new Padding(4);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(301, 32);
            usernameField.TabIndex = 21;
            // 
            // passwordLabel
            // 
            passwordLabel.Location = new Point(77, 273);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(302, 32);
            passwordLabel.TabIndex = 20;
            passwordLabel.Text = "Пароль";
            // 
            // usernameLabel
            // 
            usernameLabel.Location = new Point(77, 186);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(302, 32);
            usernameLabel.TabIndex = 19;
            usernameLabel.Text = "Имя пользователя";
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(77, 103);
            titleLabel.Margin = new Padding(5, 0, 5, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(302, 48);
            titleLabel.TabIndex = 18;
            titleLabel.Text = "Register";
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
            showHideBtn.Location = new Point(345, 308);
            showHideBtn.Name = "showHideBtn";
            showHideBtn.Size = new Size(33, 32);
            showHideBtn.TabIndex = 26;
            showHideBtn.UseVisualStyleBackColor = false;
            showHideBtn.Click += showHideBtn_Click;
            // 
            // showHide2Btn
            // 
            showHide2Btn.BackColor = Color.Transparent;
            showHide2Btn.BackgroundImage = Properties.Resources.hide_svgrepo_com;
            showHide2Btn.BackgroundImageLayout = ImageLayout.Zoom;
            showHide2Btn.FlatAppearance.BorderSize = 0;
            showHide2Btn.FlatStyle = FlatStyle.Flat;
            showHide2Btn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            showHide2Btn.Location = new Point(346, 407);
            showHide2Btn.Name = "showHide2Btn";
            showHide2Btn.Size = new Size(33, 32);
            showHide2Btn.TabIndex = 27;
            showHide2Btn.UseVisualStyleBackColor = false;
            showHide2Btn.Click += showHide2Btn_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 653);
            Controls.Add(showHide2Btn);
            Controls.Add(showHideBtn);
            Controls.Add(passwordVerifyField);
            Controls.Add(passwordVerifyLabel);
            Controls.Add(registerBtn);
            Controls.Add(passwordField);
            Controls.Add(usernameField);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(titleLabel);
            Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox passwordVerifyField;
        private System.Windows.Forms.Label passwordVerifyLabel;

        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label titleLabel;

        #endregion

        private Button showHideBtn;
        private Button showHide2Btn;
    }
}
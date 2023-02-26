using System.ComponentModel;

namespace WinFormsApp.Forms;

partial class Home
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
        titleLabel = new Label();
        SuspendLayout();
        // 
        // titleLabel
        // 
        titleLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
        titleLabel.Location = new Point(201, 151);
        titleLabel.Margin = new Padding(4, 0, 4, 0);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(259, 59);
        titleLabel.TabIndex = 17;
        titleLabel.Text = "Home page";
        titleLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // Home
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(669, 370);
        Controls.Add(titleLabel);
        Name = "Home";
        Text = "Home";
        ResumeLayout(false);
    }

    #endregion

    private Label titleLabel;
}
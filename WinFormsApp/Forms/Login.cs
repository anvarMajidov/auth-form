﻿namespace WinFormsApp.Forms;

public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();
    }

    private void label2_Click(object sender, EventArgs e)
    {
        textBox1.Focus();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void label3_Click(object sender, EventArgs e)
    {
        textBox2.Focus();
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class FrmLogin : Form
    {
        LoginModel lm = new LoginModel();
        Cipher cipher = new Cipher();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if ((TxtUsername.Text.Length > 0) && (TxtPassword.Text.Length > 0))
            {
                foreach (string[] login in lm.Logins)
                {
                    if ((login[0].ToLower() == TxtUsername.Text.ToLower()) && (login[1] == cipher.Shift(TxtPassword.Text,3)))
                    {
                        MessageBox.Show("Successful Login", "Login Attempt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmWelcomeScreen welcomeScreen = new FrmWelcomeScreen();
                        this.Hide();
                        welcomeScreen.ShowDialog();
                        this.Close();
                    }
                }
            }
        }
    }
}

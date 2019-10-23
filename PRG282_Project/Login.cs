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
        PersonModel pm = new PersonModel();
        Cipher cipher = new Cipher();
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool logged = false;
            if ((TxtUsername.Text.Length > 0) && (TxtPassword.Text.Length > 0))
            {
                foreach (string[] login in lm.Logins)
                {
                    if ((login[0].ToLower() == TxtUsername.Text.ToLower()) && (login[1] == cipher.Shift(TxtPassword.Text,3)))
                    {
                        logged = true;
                        MessageBox.Show("Successful Login", "Login Attempt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmWelcomeScreen welcomeScreen = new FrmWelcomeScreen(pm.IsAboveOfficer(login[0]),login[0]);
                        this.Hide();
                        welcomeScreen.ShowDialog();
                        this.Close();
                    }
                }
            }
            if (!logged)
            {
                MessageBox.Show("Wrong credentials");
                TxtPassword.Clear();
                TxtUsername.Clear();
            }
        }

        
    }
}

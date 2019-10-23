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
    public partial class FrmPreviousMessages : Form
    {
        bool isOfficerHigher;
        string username;
        
        public FrmPreviousMessages(bool isOfficerHigher, string username)
        {
            this.isOfficerHigher = isOfficerHigher;
            this.username = username;
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FrmWelcomeScreen welcomeScreen = new FrmWelcomeScreen(this.isOfficerHigher, this.username);
            this.Hide();
            welcomeScreen.ShowDialog();
            this.Close();
        }
    }
}

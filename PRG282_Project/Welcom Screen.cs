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
    public partial class FrmWelcomeScreen : Form
    {
        public FrmWelcomeScreen(bool isOfficerHigher,string username)
        {
            InitializeComponent();
            Console.WriteLine(isOfficerHigher);
            LblWelcome.Text = string.Format("Welcome {0}", username);
            if (isOfficerHigher == false)
            {
                BtnEncryptMessage.Visible = false;
                BtnViewDecryptedMessages.Visible = false;
                BtnAddUser.Visible = false;
            }
        }

        private void BtnDecryptMessage_Click(object sender, EventArgs e)
        {
            FrmEncryptDecrypt encryptDecrypt = new FrmEncryptDecrypt(true);
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {

        }

        private void BtnEncryptMessage_Click(object sender, EventArgs e)
        {
            FrmEncryptDecrypt encryptDecrypt = new FrmEncryptDecrypt(false);
        }
    }
}

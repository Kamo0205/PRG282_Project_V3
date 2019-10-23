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
        bool isOfficerHigher;
        string username;
        public FrmWelcomeScreen(bool isOfficerHigher,string username)
        {
            this.isOfficerHigher = isOfficerHigher;
            this.username = username;
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
            FrmEncryptDecrypt encryptDecrypt = new FrmEncryptDecrypt(false,this.isOfficerHigher,this.username);
            this.Hide();
            encryptDecrypt.ShowDialog();
            this.Close();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            FrmModifyUsers modifyUsers = new FrmModifyUsers();
            this.Hide();
            modifyUsers.ShowDialog();
            this.Close();
        }

        private void BtnEncryptMessage_Click(object sender, EventArgs e)
        {
            FrmEncryptDecrypt encryptDecrypt = new FrmEncryptDecrypt(true, this.isOfficerHigher, this.username);
            this.Hide();
            encryptDecrypt.ShowDialog();
            this.Close();
        }

        private void BtnViewPreviousMessages_Click(object sender, EventArgs e)
        {
            FrmPreviousMessages previousMessages = new FrmPreviousMessages(this.isOfficerHigher, this.username);
            this.Hide();
            previousMessages.ShowDialog();
            this.Close();
        }

        private void BtnViewDecryptedMessages_Click(object sender, EventArgs e)
        {
            FrmAllDecryptedMessages allDecryptedMessages = new FrmAllDecryptedMessages();
            this.Hide();
            allDecryptedMessages.ShowDialog();
            this.Close();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

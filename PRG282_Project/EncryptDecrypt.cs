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
    public partial class FrmEncryptDecrypt : Form
    {
        FileHandler fh;
        Cipher cipher = new Cipher();
        bool isOfficerHigher;
        string username;
        public FrmEncryptDecrypt(bool encrypt, bool isOfficerHigher, string username)
        {
            this.isOfficerHigher = isOfficerHigher;
            this.username = username;
            InitializeComponent();
            if (encrypt)
            {
                BtnDecrypt.Visible = false;
            }
            else
            {
                BtnEncrypt.Visible = false;
            }
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            DialogResult result = OfdFiles.ShowDialog();
            if (result == DialogResult.OK)
            {
                TxtFileLocation.Text = OfdFiles.FileName;
            }
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            fh = new FileHandler(TxtFileLocation.Text);
            foreach (string item in fh.Read())
            {
                TxtOriginal.Text += item + " ";
            }
            fh.Write(cipher.Decrypt(fh.Read()));
            foreach (string item in fh.Read())
            {
                TxtNew.Text += item + " ";

            }
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            fh = new FileHandler(TxtFileLocation.Text);
            foreach (string item in fh.Read())
            {
                TxtOriginal.Text += item + " ";
            }
            fh.Write(cipher.Encrypt(fh.Read()));
            foreach (string item in fh.Read())
            {
                TxtNew.Text += item + " ";
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FrmWelcomeScreen welcomeScreen = new FrmWelcomeScreen(this.isOfficerHigher,this.username);
            this.Hide();
            welcomeScreen.ShowDialog();
            this.Close();
        }
    }
}

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
        public FrmEncryptDecrypt(bool encrypt)
        {
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRG282_Project
{
    class LoginModel
    {
        DataHandler dh;
        List<string[]> logins;

        public LoginModel()
        {
            this.dh = new DataHandler();
            this.logins = dh.ReadLogins();
        }

        public List<string[]> Logins { get => logins; }
    }
}

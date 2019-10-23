using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRG282_Project
{
    class LoginModel
    {
        Controller cn;
        List<string[]> logins;

        public LoginModel()
        {
            this.cn = new Controller();
            this.logins = cn.ReadLogins();
        }

        public List<string[]> Logins { get { return logins; } }
        private int myVar;
	
    }
}

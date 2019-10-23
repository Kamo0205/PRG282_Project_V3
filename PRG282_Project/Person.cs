using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRG282_Project
{
    class Person
    {
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private string rank;

        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private Cipher cipher;

        public Cipher Cipher
        {
            get { return cipher; }
            set { cipher = value; }
        }
        
        
        

        public Person(string id, string name, string surname, int age, string rank, string password)
        {
            cipher = new Cipher();
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.rank = rank;
            this.username = this.Name.Substring(0,3)+this.Surname.Substring(this.Surname.Length - 2,2);
            this.password = cipher.Shift(password,3);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6}",this.id,this.username,this.name,this.surname,this.age,this.rank,this.password);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRG282_Project
{
    class Person
    {
        private string id;
        private string name;
        private string surname;
        private int age;
        private string rank;
        private string username;
        private string password;
        private Cipher cipher;

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

        public string Id { get => id; }
        public string Name { get => name; }
        public string Surname { get => surname; }
        public int Age { get => age; }
        public string Rank { get => rank; }
        public string Username { get => username; }
        public string Password { get => password; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6}",this.id,this.username,this.name,this.surname,this.age,this.rank,this.password);
        }
    }
}

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
    public partial class ModifyUsers : Form
    {
        PersonModel pm = new PersonModel();
        DataHandler dh = new DataHandler();
        BindingSource bs = new BindingSource();
        public ModifyUsers()
        {
            InitializeComponent();
            LstUsers.SelectionMode = SelectionMode.One;
            Refresh();
        }

        public void Refresh()
        {
            bs.DataSource = pm.People;
            LstUsers.DataSource = bs;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            
        }

        private void LstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person person = (Person)LstUsers.SelectedItem;
            TxtName.Text = person.Name;
            TxtSurname.Text = person.Surname;
            TxtAge.Text = person.Age.ToString();
            TxtUsername.Text = person.Name.Substring(0, 3) + person.Surname.Substring(person.Surname.Length - 2,2);
            bs.DataSource = dh.ReadLogins();
            CmbRank.DataSource = bs;
            TxtPassword.Text = person.Password;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Console.WriteLine(CmbRank.SelectedItem);
            //dh.AddPerson(new Person("0",TxtName.Text,TxtSurname.Text,int.Parse(TxtAge.Text),CmbRank.SelectedItem))
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PRG282_Project
{
    class Controller
    {
        public List<Person> ReadPeople()
        {
            DataHandler dh = new DataHandler();
            List<Person> people = new List<Person>();
            DataTable dt = dh.GetPeople();
            foreach (DataRow row in dt.Rows)
            {
                people.Add(new Person(row["IDNumber"].ToString(), row["Name"].ToString(), row["Surname"].ToString(), int.Parse(row["Age"].ToString()), row["Title"].ToString(), row["Password"].ToString()));
            }
            return people;
        }
        public List<Message> ReadMessages()
        {
            DataHandler dh = new DataHandler();
            List<Message> messages = new List<Message>();
            DataTable dt = dh.GetMessages();
            foreach (DataRow row in dt.Rows)
            {
                messages.Add(new Message(new Person("", row["Name"].ToString(), row["Surname"].ToString(), 0, "", ""), row["Content"].ToString()));
            }
            return messages;
        }
        public List<string[]> ReadLogins()
        {
            DataHandler dh = new DataHandler();
            DataTable dt = dh.GetLogins();
            List<string[]> logins = new List<string[]>();
            foreach (DataRow row in dt.Rows)
            {
                string[] str = new string[] { row["Username"].ToString(), row["Password"].ToString() };
                logins.Add(str);
            }
            return logins;
        }
        public List<string[]> ReadRanks()
        {
            DataHandler dh = new DataHandler();
            List<string[]> ranks = new List<string[]>();
            DataTable dt = dh.GetRanks();
            foreach (DataRow row in dt.Rows)
            {
                string[] str = new string[] { row["RankID"].ToString(), row["Title"].ToString() };
                ranks.Add(str);
            }
            return ranks;
        }
    }
}

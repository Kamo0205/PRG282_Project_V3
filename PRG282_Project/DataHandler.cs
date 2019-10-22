using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PRG282_Project
{
    class DataHandler
    {
        SqlConnection conn;

        public DataHandler()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstring"].ConnectionString);
        }

        public  List<Person> ReadPeople()
        {
            DataTable result = new DataTable();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    string query = @"Select * From [User Info]";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    adapter.Fill(result);
                }
            }
            catch (SqlException SqlEx)
            {
                Console.WriteLine(SqlEx.Message); ;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            List<Person> temp = new List<Person>();
            foreach (DataRow row in result.Rows)
            {
                temp.Add(new Person(row["IDNumber"].ToString(), row["Name"].ToString(), row["Surname"].ToString(), int.Parse(row["Age"].ToString()),row["Title"].ToString(), row["Password"].ToString()));
            }
            return temp;
        }

        public List<Message> ReadMessages()
        {
            DataTable result = new DataTable();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    string query = @"Select * From [Message Info]";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    adapter.Fill(result);
                }
            }
            catch (SqlException SqlEx)
            {
                Console.WriteLine(SqlEx.Message); ;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            List<Message> temp = new List<Message>();
            foreach (DataRow row in result.Rows)
            {
                temp.Add(new Message(new Person("", row["Name"].ToString(), row["Surname"].ToString(), 0, "", ""),row["Content"].ToString()));
            }
            return temp;
        }

        public List<string[]> ReadLogins()
        {
            DataTable result = new DataTable();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    string query = @"Select * From [Login Info]";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    adapter.Fill(result);
                }
            }
            catch (SqlException SqlEx)
            {
                Console.WriteLine(SqlEx.Message); ;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            List<string[]> temp = new List<string[]>();
            foreach (DataRow row in result.Rows)
            {
                string[] str = new string[] { row["Username"].ToString(), row["Password"].ToString() };
                temp.Add(str);
            }
            return temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PRG282_Project
{
    delegate int GetRankID(string rank);
    class DataHandler
    {
        SqlConnection conn;
        GetRankID getRankID;

        public DataHandler()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstring"].ConnectionString);
            Controller cn = new Controller();
            getRankID = new GetRankID((string rank) =>
            {
                int targetRank = 0;
                foreach (string[] item in cn.ReadRanks())
                {
                    if (rank.ToLower() == item[1].ToLower())
                    {
                        targetRank = int.Parse(item[0]);
                    }
                }
                return targetRank;
            });
        }

        public DataTable GetPeople()
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

            return result;
        }

        public int AddPerson(Person person)
        {
            int result = 0;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    string query = string.Format(@"Begin Try
	Begin Transaction
		Insert Into [tblUsers]([Name],[Surname],[Age],[RankID],[Username],[Password])
		Values('{0}','{1}',{2},{3},'{4}','{5}')
	Commit Transaction
End Try
Begin Catch
	Rollback
End Catch", person.Name, person.Surname, person.Age, getRankID(person.Rank), person.Username, person.Password);

                    SqlCommand cmd = new SqlCommand(query, conn);
                    result = cmd.ExecuteNonQuery();
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
            return result;
        }

        public int DeletePerson(Person person)
        {
            int result = 0;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    string query = string.Format(@"Begin Try
	Begin Transaction
		Delete From [tblUsers]
        Where [Name] = '{0}' And [Surname] = '{1}'
	Commit Transaction
End Try
Begin Catch
	Rollback
End Catch", person.Name, person.Surname);

                    SqlCommand cmd = new SqlCommand(query, conn);
                    result = cmd.ExecuteNonQuery();
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
            return result;
        }

        public int UpdatePerson(Person oldPerson, Person newPerson)
        {
            int result = 0;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    string query = string.Format(@"Begin Try
	Begin Transaction
		Update [tblUsers]
        set [Name] = '{0}',[Surname] = '{1}',[Age] = {2},[RankID] = {3},[Username] = '{4}',[Password] = '{5}'
        Where [Name] = '{6}' And [Surname] = '{7}'
	Commit Transaction
End Try
Begin Catch
	Rollback
End Catch", oldPerson.Name, oldPerson.Surname, oldPerson, oldPerson.Age, getRankID(oldPerson.Rank), oldPerson.Password, newPerson.Name, newPerson.Surname);

                    SqlCommand cmd = new SqlCommand(query, conn);
                    result = cmd.ExecuteNonQuery();
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
            return result;
        }

        public DataTable GetMessages()
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
            return result;
        }

        public DataTable GetLogins()
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
            
            return result;
        }

        public DataTable GetRanks()
        {
            DataTable result = new DataTable();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    string query = @"Select * From [tblRanks]";

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
            
            return result;
        }
    }
}

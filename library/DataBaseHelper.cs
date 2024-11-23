using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class DataBaseHelper
    {
        MySqlConnection myConn;
        public DataBaseHelper() 
        {
            string connStr = "server=localhost;user=root;database=library;port=3306;password=root";
            myConn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                myConn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public bool CheckUser(string login, string password)
        {
            string sql = $"SELECT COUNT(*) as count FROM user WHERE login='{login}' AND password='{password}'";
            MySqlCommand cmd = new MySqlCommand(sql, myConn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                return rdr[0].ToString() != "0";
            }

            rdr.Close();
            return false;
        }
    }
}

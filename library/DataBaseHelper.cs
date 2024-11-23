using System;
using System.Data.SqlClient;
using System.Configuration;

namespace library
{
    internal class DataBaseHelper
    {
        private readonly SqlConnection sqlConnection;

        public DataBaseHelper()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBLibrary.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            try
            {
                Console.WriteLine("Connecting to SQL Server...");
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection Error: {ex.Message}");
            }
        }

        public bool CheckUser(string login, string password)
        {
            // Використовуємо параметризований запит для захисту від SQL-ін'єкцій
            string sql = "SELECT COUNT(*) FROM [user] WHERE login = @Login AND password = @Password";

            using (SqlCommand command = new SqlCommand(sql, sqlConnection))
            {
                // Додаємо параметри
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Query Error: {ex.Message}");
                    return false;
                }
            }
        }

        // Метод для закриття з'єднання
        public void CloseConnection()
        {
            if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        // Реалізація IDisposable для коректного звільнення ресурсів
        public void Dispose()
        {
            CloseConnection();
            sqlConnection?.Dispose();
        }
    }
}
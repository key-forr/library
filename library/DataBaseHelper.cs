using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

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
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool CheckUser(string login, string password)
        {
            string sql = "SELECT COUNT(*) FROM [user] WHERE login = @Login AND password = @Password";
            using (SqlCommand command = new SqlCommand(sql, sqlConnection))
            {
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);
                try
                {
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Query Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public int GetUserId(string login)
        {
            string sql = "SELECT id FROM [user] WHERE login = @Login";
            using (SqlCommand command = new SqlCommand(sql, sqlConnection))
            {
                command.Parameters.AddWithValue("@Login", login);
                try
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    return -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error getting user ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }
        }

        public bool SaveReminder(string title, string description, string login)
        {
            int userId = GetUserId(login);
            if (userId == -1)
            {
                MessageBox.Show("User not found. Reminder cannot be saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string sql = "INSERT INTO [reminder] (title, description, userId) VALUES (@Title, @Description, @UserId)";
            using (SqlCommand command = new SqlCommand(sql, sqlConnection))
            {
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@UserId", userId);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reminder successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Reminder was not saved. No rows affected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving reminder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        ~DataBaseHelper()
        {
            CloseConnection();
            sqlConnection?.Dispose();
        }

        public void Dispose()
        {
            CloseConnection();
            sqlConnection?.Dispose();
        }
    }
}

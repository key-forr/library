using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace library
{
    internal class DataBaseHelper : IDisposable
    {
        private readonly MySqlConnection sqlConnection;
        private bool disposed = false;

        public DataBaseHelper()
        {
            string connStr = "server=localhost;user=root;database=library;port=3306;password=root";
            sqlConnection = new MySqlConnection(connStr);
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show($"Database connection error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool CheckUser(string login, string password)
        {
            string sql = "SELECT COUNT(*) FROM user WHERE login=@Login AND password=@Password";
            using (MySqlCommand cmd = new MySqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@Login", login);
                cmd.Parameters.AddWithValue("@Password", password);

                try
                {
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error checking user: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool SaveReminder(string title, string description, string login)
        {
            string sql = "INSERT INTO reminder (title, description, userId) VALUES (@Title, @Description, @UserId)";
            using (MySqlCommand command = new MySqlCommand(sql, sqlConnection))
            {
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@UserId", UserSession.Id);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reminder successfully saved!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Reminder was not saved. No rows affected.", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving reminder: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public void LoadRemindersIntoDataGrid(HomeForm homeForm, int userId)
        {
            string sql = "SELECT title, description FROM reminder WHERE userId = @UserId";

            try
            {
                using (var command = new MySqlCommand(sql, sqlConnection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    var reminderDataTable = new DataTable();
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(reminderDataTable);
                    }
                    homeForm.UpdateReminderDataGrid(reminderDataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reminders: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetUserData(string login)
        {
            string sql = "SELECT user.name, user.phone, user.password, role.name, ifnull(user.surname, ''), user.id FROM user LEFT JOIN role ON role.id = user.roleId WHERE user.login = @login";

            using (MySqlCommand command = new MySqlCommand(sql, sqlConnection))
            {
                command.Parameters.AddWithValue("@Login", login);
                try
                {
                    using (MySqlDataReader rdr = command.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string Name     = rdr.GetString(0);
                            string Phone    = rdr.GetString(1);
                            string Password = rdr.GetString(2);
                            string roleName = rdr.GetString(3);
                            string Surname  = rdr.GetString(4);
                            int    id       = rdr.GetInt32(5);

                            UserSession.Name     = Name;
                            UserSession.Phone    = Phone;
                            UserSession.Password = Password;
                            UserSession.RoleName = roleName;
                            UserSession.Surname  = Surname;
                            UserSession.Id       = id;
                        }
                    }
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error getting user ID: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    CloseConnection();
                    sqlConnection?.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~DataBaseHelper()
        {
            Dispose(false);
        }
    }
}
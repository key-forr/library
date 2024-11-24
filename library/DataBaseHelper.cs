using System;
using System.Data;
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

        public int GetUserId(string login)
        {
            string sql = "SELECT id FROM user WHERE login = @Login";
            using (MySqlCommand command = new MySqlCommand(sql, sqlConnection))
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
                    MessageBox.Show($"Error getting user ID: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }
        }

        public bool SaveReminder(string title, string description, string login)
        {
            int userId = GetUserId(login);
            if (userId == -1)
            {
                MessageBox.Show("User not found. Reminder cannot be saved.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string sql = "INSERT INTO reminder (title, description, userId) VALUES (@Title, @Description, @UserId)";
            using (MySqlCommand command = new MySqlCommand(sql, sqlConnection))
            {
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@UserId", userId);

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

        public void LoadRemindersToDataGrid(HomeForm homeForm, int userId)
        {
            string sql = "SELECT title, description FROM reminder WHERE userId = @UserId";

            try
            {
                using (MySqlCommand command = new MySqlCommand(sql, sqlConnection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    DataTable dt = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }

                    homeForm.MyDataGridView.DataSource = null;
                    homeForm.MyDataGridView.Columns.Clear();
                    homeForm.MyDataGridView.DataSource = dt;

                    // Налаштування стовпців
                    if (homeForm.MyDataGridView.Columns.Count > 0)
                    {
                        // Налаштування заголовків стовпців
                        homeForm.MyDataGridView.Columns["title"].HeaderText = "Заголовок";
                        homeForm.MyDataGridView.Columns["description"].HeaderText = "Опис";

                        // Налаштування ширини стовпців
                        homeForm.MyDataGridView.Columns["title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        homeForm.MyDataGridView.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        // Додаткові налаштування для кращого вигляду
                        homeForm.MyDataGridView.ColumnHeadersHeight = 40;
                        homeForm.MyDataGridView.RowTemplate.Height = 40;
                        homeForm.MyDataGridView.AllowUserToAddRows = false;
                        homeForm.MyDataGridView.AllowUserToDeleteRows = false;
                        homeForm.MyDataGridView.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reminders: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
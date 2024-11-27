using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Guna.UI2.WinForms;
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
                            string Name = rdr.GetString(0);
                            string Phone = rdr.GetString(1);
                            string Password = rdr.GetString(2);
                            string roleName = rdr.GetString(3);
                            string Surname = rdr.GetString(4);
                            int id = rdr.GetInt32(5);

                            UserSession.Name = Name;
                            UserSession.Phone = Phone;
                            UserSession.Password = Password;
                            UserSession.RoleName = roleName;
                            UserSession.Surname = Surname;
                            UserSession.Id = id;
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

        public void LoadGenreIntoComboBox(ComboBox comboBox)
        {
            string query = "SELECT name FROM genre";
            try
            {
                using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox.Items.Add(reader["name"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження жанрів: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool AddBook(string name, string author, int year, string publishing, int quantity, string photoPath, int genreId)
        {
            string sql = "INSERT INTO book (name, author, year, publishing, quantity, photo, genre_id) " +
                         "VALUES (@Name, @Author, @Year, @Publishing, @Quantity, @Photo, @GenreId)";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Author", author);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Publishing", publishing);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Photo", photoPath);
                    cmd.Parameters.AddWithValue("@GenreId", genreId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void LoadBooksFromDatabase(Form form)
        {
            // MySQL query to retrieve book information
            string query = @"
        SELECT 
            name,
            author,
            quantity,
            photo
    FROM book";

            using (MySqlCommand command = new MySqlCommand(query, sqlConnection)) // Assuming mySqlConnection is your MySqlConnection
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    int x = 50;  
                    int y = 50;  
                    int bookCount = 0;

                    while (reader.Read())
                    {
                        // Extracting book data
                        string bookTitle = reader["name"].ToString();
                        string author = reader["author"].ToString();
                        int count = Convert.ToInt32(reader["quantity"]);
                        string imagePath = reader["photo"].ToString();

                        // Creating GroupBox for the book
                        Guna.UI2.WinForms.Guna2GroupBox bookCard = CreateSomeTool.CreateBookCard(
                            bookTitle,
                            author,
                            count,
                            x,
                            y,
                            imagePath
                        );

                        form.Controls.Add(bookCard);

                        x += 400;  
                        bookCount++;

                        if (bookCount % 2 == 0)
                        {
                            x = 50;       
                            y += 200;     
                        }
                    }
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
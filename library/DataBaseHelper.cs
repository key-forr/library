using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using static Guna.UI2.Native.WinApi;

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
            string query = "SELECT COUNT(*) FROM user WHERE login=@Login AND password=@Password";

            using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    long count = (long)command.ExecuteScalar();
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
            string query = "INSERT INTO reminder (title, description, userId) VALUES (@Title, @Description, @UserId)";

            using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
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

        public void GetUserData(string login)
        {
            string query = "SELECT id, name, ifnull(surname, ''), phone, login, password, roleId FROM user WHERE login = @login";

            using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@Login", login);

                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserSession.Id = Convert.ToInt32(reader["id"]);
                            UserSession.Name = reader["name"].ToString(); 
                            UserSession.Phone = reader["phone"].ToString();
                            UserSession.Login = reader["login"].ToString();
                            UserSession.Password = reader["password"].ToString();
                            UserSession.RoleId = Convert.ToInt32(reader["roleId"]);
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

        public List<GenreConfig> LoadGenres()
        {
            string query = "SELECT id, name FROM genre";

            List<GenreConfig> Genres = new List<GenreConfig>();

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GenreConfig genreConfig = new GenreConfig
                            (
                                Convert.ToInt32(reader["id"]),
                                reader["name"].ToString()
                            );
                           

                            Genres.Add(genreConfig);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження жанрів: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Genres;
        }

        public List<RolesConfig> LoadRoles()
        {
            string query = "SELECT id, name FROM role";

            List<RolesConfig> roles = new List<RolesConfig>();

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RolesConfig genreConfig = new RolesConfig
                            (
                                Convert.ToInt32(reader["id"]),
                                reader["name"].ToString()
                            );


                            roles.Add(genreConfig);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження жанрів: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return roles;
        }

        public bool AddBook(string name, string author, int year, string publishing,
                            int quantity, string photoPath, int genreId)
        {
            string query = "INSERT INTO book (name, author, year, publishing, quantity, photo, genreId) " +
                         "VALUES (@Name, @Author, @Year, @Publishing, @Quantity, @Photo, @GenreId)";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Author", author);
                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@Publishing", publishing);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Photo", photoPath);
                    command.Parameters.AddWithValue("@GenreId", genreId);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<BookConfig> LoadBooks()
        {
            string query = @"SELECT id, name, author, year, publishing, quantity, photo, genreId" +
                " FROM book ";

            List<BookConfig> books = new List<BookConfig>();

            using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BookConfig bookCardConfig = new BookConfig
                        (
                            Convert.ToInt32(reader["id"]),
                            reader["name"].ToString(),
                            reader["author"].ToString(),
                            Convert.ToInt32(reader["year"]),
                            reader["publishing"].ToString(),
                            Convert.ToInt32(reader["quantity"]),
                            reader["photo"].ToString(),
                            Convert.ToInt32(reader["genreId"])
                        );

                        books.Add(bookCardConfig);
                    }
                }
            }

            return books;
        }

        public BookConfig LoadBookDetails(int bookId)
        {
            string query = "SELECT id, name, author, year, publishing, quantity, photo, genreId" +
                " FROM book WHERE id = @id";

            using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@id", bookId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new BookConfig
                        (
                            Convert.ToInt32(reader["id"]),
                            reader["name"].ToString(),
                            reader["author"].ToString(),
                            Convert.ToInt32(reader["year"]),
                            reader["publishing"].ToString(),
                            Convert.ToInt32(reader["quantity"]),
                            reader["photo"].ToString(),
                            Convert.ToInt32(reader["genreId"])
                        );
                    }
                }
            }

            return null;
        }

        public List<ReminderConfig> LoadReminder()
        {
            string query = @"SELECT id, title, description FROM reminder WHERE userId = @userId";

            List<ReminderConfig> reminderCards = new List<ReminderConfig>();

            using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@userId", UserSession.Id);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReminderConfig reminderCardConfig = new ReminderConfig
                        (
                            Convert.ToInt32(reader["id"]),
                            reader["title"].ToString(),
                            reader["description"].ToString()
                        );

                        reminderCards.Add(reminderCardConfig);
                    }
                }
            }

            return reminderCards;
        }

        public void UpdateBook(BookConfig bookCardConfig)
        {
            string query = @"UPDATE book 
                     SET name = @bookName, 
                         author = @author, 
                         genreId = @genreId, 
                         year = @year, 
                         publishing = @publishing, 
                         quantity = @quantity 
                     WHERE id = @bookId";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@bookName", bookCardConfig.Name);
                    command.Parameters.AddWithValue("@author", bookCardConfig.Author);
                    command.Parameters.AddWithValue("@genreId", bookCardConfig.GenreId = 1);
                    command.Parameters.AddWithValue("@year", bookCardConfig.Year);
                    command.Parameters.AddWithValue("@publishing", bookCardConfig.Publishing);
                    command.Parameters.AddWithValue("@quantity", bookCardConfig.Quantity);
                    command.Parameters.AddWithValue("@bookId", bookCardConfig.Id);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error update book: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
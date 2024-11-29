using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
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

        public BookCardConfig LoadBookDetails(int bookId)
        {
            string query = "SELECT book.id, book.name, author, quantity, year, publishing, genre.name as genreName, photo FROM book LEFT JOIN genre ON genre.id = book.genre_id WHERE book.id = @id";
            using (var command = new MySqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@id", bookId);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new BookCardConfig
                        (
                            Convert.ToInt32(reader["id"]),
                            reader["name"].ToString(),
                            reader["author"].ToString(),
                            Convert.ToInt32(reader["quantity"]),
                            reader["photo"].ToString(),
                            Convert.ToInt32(reader["year"]),
                            reader["publishing"].ToString(),
                            reader["genreName"].ToString()
                        );
                    }
                }
            }

            return null;
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
            string query = "SELECT user.name, user.phone, user.password, role.name, ifnull(user.surname, ''), user.id FROM user LEFT JOIN role ON role.id = user.roleId WHERE user.login = @login";

            using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@Login", login);
                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string Name = reader.GetString(0);
                            string Phone = reader.GetString(1);
                            string Password = reader.GetString(2);
                            string roleName = reader.GetString(3);
                            string Surname = reader.GetString(4);
                            int id = reader.GetInt32(5);

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
            string query = "INSERT INTO book (name, author, year, publishing, quantity, photo, genre_id) " +
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

        public List<BookCardConfig> LoadBookDataForCard()
        {
            string query = @"SELECT book.id, book.name, author, quantity, year, publishing, genre.name as genreName, photo FROM book LEFT JOIN genre ON genre.id = book.genre_id ";

            List<BookCardConfig> books = new List<BookCardConfig>();

            using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BookCardConfig bookCardConfig = new BookCardConfig(
                            Convert.ToInt32(reader["id"]),        
                            reader["name"].ToString(),          
                            reader["author"].ToString(),         
                            Convert.ToInt32(reader["quantity"]), 
                            reader["photo"].ToString(),
                            Convert.ToInt32(reader["year"]),
                            reader["publishing"].ToString(),
                            reader["genreName"].ToString()
                        );

                        books.Add(bookCardConfig);
                    }
                }
            }

            return books;
        }

        public List<Guna.UI2.WinForms.Guna2GroupBox> LoadReminderDataForCard(ReminderListForm form)
        {
            string query = @"SELECT title, description FROM reminder WHERE userId = @userId";
            List<Guna.UI2.WinForms.Guna2GroupBox> reminderCards = new List<Guna.UI2.WinForms.Guna2GroupBox>();

            using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@userId", UserSession.Id);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    int x = 15;
                    int y = 5;
                    ReminderCardFactory reminderCardFactory = new ReminderCardFactory(form);
                    while (reader.Read())
                    {
                        ReminderCardConfig reminderCardConfig = new ReminderCardConfig(
                            reader["title"].ToString(),
                            reader["description"].ToString(),
                            "");

                        Guna.UI2.WinForms.Guna2GroupBox reminderCard = reminderCardFactory.CreateReminderCard(
                            reminderCardConfig,
                            x,
                            y
                        );

                        reminderCards.Add(reminderCard);
                        y += 110; 
                    }
                }
            }

            return reminderCards;
        }

        public void UpdateBook(BookCardConfig bookCardConfig)
        {
            string query = @"UPDATE book 
                     SET name = @book_name, 
                         author = @author, 
                         genre_id = @genre_id, 
                         year = @year, 
                         publishing = @publishing, 
                         quantity = @quantity 
                     WHERE id = @book_id";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
                {
                    // Додаємо параметри до команди
                    command.Parameters.AddWithValue("@book_name", bookCardConfig.Title);
                    command.Parameters.AddWithValue("@author", bookCardConfig.Author);
                    command.Parameters.AddWithValue("@genre_id", bookCardConfig.GenreId = 1);
                    command.Parameters.AddWithValue("@year", bookCardConfig.Year);
                    command.Parameters.AddWithValue("@publishing", bookCardConfig.Publishing);
                    command.Parameters.AddWithValue("@quantity", bookCardConfig.Count);
                    command.Parameters.AddWithValue("@book_id", bookCardConfig.Id);

                    // Виконуємо команду
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Виводимо повідомлення про помилку
                MessageBox.Show($"Error update book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
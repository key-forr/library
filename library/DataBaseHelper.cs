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

        public bool SaveReminder(DateTime date, string title, string description, string login)
        {
            string query = "INSERT INTO reminder (title, description, userId, date) VALUES (@Title, @Description, @UserId, @Date)";

            using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@UserId", UserSession.Id);
                command.Parameters.AddWithValue("@Date", date);

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
            string query = "SELECT id, name, surname, phone, login, password, roleId FROM user WHERE login = @login";

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
                            UserSession.Surname = reader["surname"].ToString();
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

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book successfully add!", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool AddUser(string name, string surname, string phone, string login, string password, int roleId)
        {
            string query = "INSERT INTO user (name, surname, phone, login, password, roleId) " +
                           "VALUES (@Name, @Surname, @Phone, @Login, @Password, @RoleId)";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Surname", surname);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@RoleId", roleId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User successfully added!", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return rowsAffected > 0; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public List<EmployeeConfig> LoadEmployee()
        {
            string query = "SELECT id, name, IFNULL(surname, '') AS surname, phone, login, password, roleId FROM user";
            List<EmployeeConfig> employees = new List<EmployeeConfig>();

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmployeeConfig employee = new EmployeeConfig
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Name = reader["name"].ToString(),
                                Surname = reader["surname"].ToString(),
                                Phone = reader["phone"].ToString(),
                                Login = reader["login"].ToString(),
                                Password = reader["password"].ToString(),
                                RoleId = Convert.ToInt32(reader["roleId"])
                            };
                            employees.Add(employee);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return employees;
        }

        public List<ReminderConfig> LoadReminder()
        {
            string query = @"SELECT id, title, description, date FROM reminder WHERE userId = @userId";

            List<ReminderConfig> reminderCards = new List<ReminderConfig>();

            using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@userId", UserSession.Id);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime? reminderDate = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);

                        ReminderConfig reminderCardConfig = new ReminderConfig
                        (
                            Convert.ToInt32(reader["id"]),
                            reader["title"].ToString(),
                            reader["description"].ToString(),
                            reminderDate 
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
                     SET name = @name, 
                         author = @author, 
                         genreId = @genreId, 
                         year = @year, 
                         publishing = @publishing, 
                         quantity = @quantity, 
                         photo = @photo
                     WHERE id = @bookId";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@name", bookCardConfig.Name);
                    command.Parameters.AddWithValue("@author", bookCardConfig.Author);
                    command.Parameters.AddWithValue("@genreId", bookCardConfig.GenreId);
                    command.Parameters.AddWithValue("@year", bookCardConfig.Year);
                    command.Parameters.AddWithValue("@publishing", bookCardConfig.Publishing);
                    command.Parameters.AddWithValue("@quantity", bookCardConfig.Quantity);

                    // Перевірка на NULL для photo
                    if (string.IsNullOrEmpty(bookCardConfig.ImagePath))
                    {
                        command.Parameters.AddWithValue("@photo", DBNull.Value); // Якщо пусто, встановити NULL
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@photo", bookCardConfig.ImagePath); // Встановити шлях до фото
                    }

                    command.Parameters.AddWithValue("@bookId", bookCardConfig.Id);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Book successfully updated!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating book: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateEmployee(EmployeeConfig employeeConfig)
        {
            string query = @"UPDATE user 
                     SET name = @name, 
                         surname = @surname, 
                         phone = @phone, 
                         login = @login, 
                         password = @password,
                         roleId = @roleId 
                     WHERE id = @employeeId";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@name", employeeConfig.Name);
                    command.Parameters.AddWithValue("@surname", employeeConfig.Surname);
                    command.Parameters.AddWithValue("@phone", employeeConfig.Phone);
                    command.Parameters.AddWithValue("@login", employeeConfig.Login);
                    command.Parameters.AddWithValue("@password", employeeConfig.Password);
                    command.Parameters.AddWithValue("@roleId", employeeConfig.RoleId);
                    command.Parameters.AddWithValue("@employeeId", employeeConfig.Id);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Employee successfully updated!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating employee: {ex.Message}",
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
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
using library.Classes.Configuration;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using static Guna.UI2.Native.WinApi;

namespace library.Classes
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

        public bool AddReminder(string title, string description, DateTime date)
        {
            string query = "INSERT INTO reminder (title, description, date, userId) VALUES (@Title, @Description, @Date, @UserId)";

            using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Date", date);
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

        public bool AddClient(string name, string surname, string patronymic, string phone)
        {
            string query = "INSERT INTO client (name, surname, patronymic, phone) " +
                           "VALUES (@Name, @Surname, @Patronymic, @Phone)";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Surname", surname);
                    command.Parameters.AddWithValue("@Patronymic", patronymic);
                    command.Parameters.AddWithValue("@Phone", phone);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Client successfully added!", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding client: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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

        public List<RoleConfig> LoadRoles()
        {
            string query = "SELECT id, name FROM role";

            List<RoleConfig> roles = new List<RoleConfig>();

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RoleConfig genreConfig = new RoleConfig
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
                MessageBox.Show($"Помилка завантаження ролів: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return roles;
        }

        public List<UserConfig> LoadUsers()
        {
            string query = "SELECT id, name, surname, phone, login, password, roleId FROM user";
            List<UserConfig> users = new List<UserConfig>();

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserConfig user = new UserConfig
                            (
                                Convert.ToInt32(reader["id"]),
                                reader["name"].ToString(),
                                reader["surname"].ToString(),
                                reader["phone"].ToString(),
                                reader["login"].ToString(),
                                reader["password"].ToString(),
                                Convert.ToInt32(reader["roleId"])
                            );
                            users.Add(user);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return users;
        }

        public List<ClientConfig> LoadClients()
        {
            string query = "SELECT id, name, surname, patronymic, phone FROM client";

            List<ClientConfig> clients = new List<ClientConfig>();

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClientConfig client = new ClientConfig
                            (
                                Convert.ToInt32(reader["id"]),
                                reader["name"].ToString(),
                                reader["surname"].ToString(),
                                reader["patronymic"].ToString(),
                                reader["phone"].ToString()
                            );
                            clients.Add(client);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading clients: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return clients;
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

        public List<OrderConfig> LoadOrders()
        {
            string query = @"SELECT id FROM `order`";

            List<OrderConfig> ordersCards = new List<OrderConfig>();

            using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OrderConfig orderConfig = new OrderConfig
                        (
                            Convert.ToInt32(reader["id"])
                        );

                        ordersCards.Add(orderConfig);
                    }
                }
            }

            return ordersCards;
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

                    if (string.IsNullOrEmpty(bookCardConfig.ImagePath))
                    {
                        command.Parameters.AddWithValue("@photo", DBNull.Value); 
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@photo", bookCardConfig.ImagePath); 
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

        public void UpdateUser(UserConfig userConfig)
        {
            string query = @"UPDATE user 
                     SET name = @name, 
                         surname = @surname, 
                         phone = @phone, 
                         login = @login, 
                         password = @password,
                         roleId = @roleId 
                     WHERE id = @userId";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@name", userConfig.Name);
                    command.Parameters.AddWithValue("@surname", userConfig.Surname);
                    command.Parameters.AddWithValue("@phone", userConfig.Phone);
                    command.Parameters.AddWithValue("@login", userConfig.Login);
                    command.Parameters.AddWithValue("@password", userConfig.Password);
                    command.Parameters.AddWithValue("@roleId", userConfig.RoleId);
                    command.Parameters.AddWithValue("@userId", userConfig.Id);

                    command.ExecuteNonQuery();

                    MessageBox.Show("User successfully updated!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateClient(ClientConfig clientConfig)
        {
            string query = @"UPDATE client 
                     SET name = @name, 
                         surname = @surname, 
                         patronymic = @patronymic, 
                         phone = @phone
                     WHERE id = @clientId";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@name", clientConfig.Name);
                    command.Parameters.AddWithValue("@surname", clientConfig.Surname);
                    command.Parameters.AddWithValue("@patronymic", clientConfig.Patronymic);
                    command.Parameters.AddWithValue("@phone", clientConfig.Phone);
                    command.Parameters.AddWithValue("@clientId", clientConfig.Id);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Client successfully updated!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}",
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
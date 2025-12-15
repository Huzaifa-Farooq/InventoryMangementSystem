using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using WinFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public class Database
    {
        private SqlConnection connection;

        public Database(string connectionString)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                CreateAdmin();
            }
            catch (Exception e)
            {
                MessageBox.Show("Database connection failed: " + e.Message);
            }
        }

        public void CreateAdmin()
        {
            string query = "SELECT * FROM users WHERE username = @username";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", "admin");
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                // already exists
                reader.Close();
                return;
            }
            reader.Close();

            CreateAccount("admin", Roles.Administrator, "admin");
        }

        public void InsertItem(Item item)
        {
            string query = "INSERT INTO items (name, description, category, quantity, price) VALUES (@name, @description, @category, @quantity, @price)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", item.Name);
            cmd.Parameters.AddWithValue("@description", item.Description);
            cmd.Parameters.AddWithValue("@category", item.Category);
            cmd.Parameters.AddWithValue("@quantity", item.Quantity);
            cmd.Parameters.AddWithValue("@price", item.Price);
            cmd.ExecuteNonQuery();
        }

        public Item RetrieveItem(int id)
        {
            string query = "SELECT * FROM items WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Item item = new Item(
                    (int)reader["id"],
                    reader["name"].ToString(),
                    reader["description"].ToString(),
                    reader["category"].ToString(),
                    (int)reader["quantity"],
                    Convert.ToDouble(reader["price"])
                );
                reader.Close();
                return item;
            }
            reader.Close();
            return null;
        }

        public bool AccountExists(string username)
        {
            string query = "SELECT * FROM users WHERE username = @username";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = cmd.ExecuteReader();
            bool exists = reader.HasRows;
            reader.Close();
            return exists;
        }

        public void CreateAccount(string username, string role, string password)
        {
            string query = "INSERT INTO users (username, role, password) VALUES (@username, @role, @password)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.ExecuteNonQuery();
        }

        public User AuthenticateUser(string username, string password)
        {
            string query = "SELECT * FROM users WHERE username = @username AND password = @password";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string role = reader["role"].ToString();
                reader.Close();
                return new User(username, role);
            }
            reader.Close();
            return null;
        }

        public User GetUser(string username)
        {
            string query = "SELECT * FROM users WHERE username = @username";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                User u = new User(username, reader["role"].ToString());
                reader.Close();
                return u;
            }
            reader.Close();
            return null;
        }

        public void DeleteItem(int id)
        {
            string query = "DELETE FROM items WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public void DeleteUser(string username)
        {
            string query = "DELETE FROM users WHERE username = @username";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.ExecuteNonQuery();
        }

        public void UpdateItemStock(int itemId, int quantity)
        {
            string query = "UPDATE items SET quantity = @quantity WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@id", itemId);
            cmd.ExecuteNonQuery();
        }

        public List<Item> GetItems()
        {
            List<Item> items = new List<Item>();
            string query = "SELECT * FROM items";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Item item = new Item(
                    (int)reader["id"],
                    reader["name"].ToString(),
                    reader["description"].ToString(),
                    reader["category"].ToString(),
                    (int)reader["quantity"],
                    Convert.ToDouble(reader["price"])
                );
                items.Add(item);
            }
            reader.Close();
            return items;
        }

        public void RemoveItem(int itemId)
        {
            string query = "DELETE FROM items WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", itemId);
            cmd.ExecuteNonQuery();
        }
    }
}

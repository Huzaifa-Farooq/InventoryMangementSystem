using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Models;
using WinFormsApp1.Models;


namespace WinFormsApp1.Controls
{
    public partial class LoginControl : UserControl
    {
        private Database db;
        public App MainForm;
        public LoginControl(Database db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show(
                    "Please enter a username and password.", // Message text
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            User u = db.AuthenticateUser(username, password);
            if (u != null)
            {
                MainForm.SetUserSession(u);
            }
            else
            {
                MessageBox.Show(
                    "Username or Password is incorrect!",
                    "Authentication Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using WinFormsApp1.Models;

namespace InventoryManagementSystem.Controls
{
    public partial class CreateAccountControl : UserControl
    {
        private Database db;

        public List<string> RolesList = new List<string>()
        {
            Roles.Cashier,
            Roles.Administrator
        };

        public CreateAccountControl(Database db)
        {
            InitializeComponent();
            comboBoxRole.DataSource = RolesList;

            this.db = db;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string role = comboBoxRole.SelectedItem.ToString();

            if (
                string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(role))
            {
                MessageBox.Show(
                    "Please enter a username, password, and select a role.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (db.AccountExists(username))
            {
                MessageBox.Show(
                    "An account with this username already exists.",
                    "Duplicate Account",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            db.CreateAccount(username, role, password);

            MessageBox.Show(
                "Account created successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearFields();

        }

        private void ClearFields()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            comboBoxRole.SelectedIndex = 0;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}

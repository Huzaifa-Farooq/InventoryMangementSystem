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
    public partial class DeleteAccountControl : UserControl
    {
        private Database db;
        private User currentUser;

        public DeleteAccountControl(Database db, User loggedInUser)
        {
            InitializeComponent();

            this.db = db;
            this.currentUser = loggedInUser;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show(
                    "Please select an account to delete.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            User selectedUser = db.GetUser(username);

            if (username == currentUser.Username || (currentUser.Role == Roles.Administrator && selectedUser.Role != Roles.Administrator))
            {
                db.DeleteUser(username);
                MessageBox.Show(
                    "Account deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                if (username == currentUser.Username)
                {
                    Application.Restart();
                }
            } else
            {
                MessageBox.Show(
                    "Unable to Delete Account.",
                    "Failure",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
        }
    }
}

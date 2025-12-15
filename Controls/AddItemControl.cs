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
    public partial class AddItemControl : UserControl
    {
        private Database db;
        public AddItemControl(Database db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string description = textBoxDescription.Text.Trim();
            string category = textBoxCategory.Text.Trim();
            int quantity = (int)numericUpDownQuantity.Value;
            double price = (double)numericUpDownPrice.Value;

            if (string.IsNullOrEmpty(name) || price <= 0 || quantity <= 0)
            {
                MessageBox.Show("Please enter item name, price and quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Item item = new Item(name, description, category, quantity, price);
            db.InsertItem(item);
            MessageBox.Show($"Item '{name}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetForm();
        }

        private void ResetForm()
        {
            textBoxName.Clear();
            textBoxDescription.Clear();
            textBoxCategory.Clear();
            numericUpDownPrice.Value = 0;
            numericUpDownQuantity.Value = 1;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void numericUpDownPrice_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

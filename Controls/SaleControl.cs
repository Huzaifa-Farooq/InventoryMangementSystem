using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using InventoryManagementSystem.Models;
using WinFormsApp1;
using WinFormsApp1.Models;


namespace InventoryManagementSystem.Controls
{
    public partial class SaleControl : UserControl
    {
        private Database db;
        private List<Item> ItemsList;
        private List<SaleItem> SelectedItems;

        public SaleControl(Database db)
        {
            this.db = db;
            InitializeComponent();
            this.ItemsList = db.GetItems();
            SelectedItems = new List<SaleItem>();

            dataGridView1.DataSource = this.SelectedItems;
        }

        private void SaleControl_Load(object sender, EventArgs e)
        {

        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = this.SelectedItems;
            dataGridView1.Refresh();

            // Update Total
            TotalPriceTextBox.Text = SelectedItems.Select(s => s.QuantityInBill * s.Price).Sum().ToString();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string query = textBoxSearch.Text.Trim();
            if (query != "")
            {

                var result = ItemsList.Where(i => i.Name.ToLower().Contains(query.ToLower())).ToList();
                listBoxResults.DataSource = result;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double paid;
            if (double.TryParse(textBoxPaid.Text, out paid))
            {
                double ReturnAmount = paid - SelectedItems.Select(s => s.QuantityInBill * s.Price).Sum();
                if (ReturnAmount < 0)
                {
                    MessageBox.Show("Invalid Amount Paid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                textBoxReturn.Text = ReturnAmount.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Input Amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // updating items stock
            foreach (var item in SelectedItems)
            {
                int ExistingStock = ItemsList.FirstOrDefault(i => i.Id == item.Id).Quantity;
                db.UpdateItemStock(item.Id, ExistingStock - item.QuantityInBill);
            }

            // clear fields
            ClearBillFields();
            RefreshGrid();
            listBoxResults.DataSource = null;
            textBoxSearch.Clear();
        }

        private void ClearBillFields()
        {
            SelectedItems.Clear();

            textBoxPaid.Clear();
            textBoxReturn.Clear();
            TotalPriceTextBox.Clear();
        }

        private void AddItem(Item item, int quantity)
        {
            if (quantity <= 0)
            {
                return;
            }
            var existing = SelectedItems.FirstOrDefault(s => s.Id == item.Id);
            if (existing != null)
            {
                int RequiredItems = existing.QuantityInBill + quantity;
                if (RequiredItems > item.Quantity)
                {
                    MessageBox.Show("Insufficient quantity in stock.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    // add item count
                    existing.QuantityInBill += quantity;
                }
            }
            else
            {
                SaleItem saleItem = new SaleItem(item, quantity);
                SelectedItems.Add(saleItem);
            }
            RefreshGrid();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (listBoxResults.SelectedItem != null)
            {
                Item i = (Item)listBoxResults.SelectedItem;
                int quantity = (int)ItemCount.Value;
                AddItem(i, quantity);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPaid_TextChanged_1(object sender, EventArgs e)
        {
            double paid;
            if (double.TryParse(textBoxPaid.Text, out paid))
            {
                double ReturnAmount = paid - SelectedItems.Select(s => s.QuantityInBill * s.Price).Sum();
                textBoxReturn.Text = ReturnAmount.ToString();
            }
        }
    }
}

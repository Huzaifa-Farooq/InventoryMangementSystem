using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class InventoryView : UserControl
    {
        private Database db;
        private List<Item> itemsList;
        private List<Item> FilteredList;
        public InventoryView(Database db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void InventoryView_Load(object sender, EventArgs e)
        {
            this.itemsList = db.GetItems();
            LoadData("");
        }
        private void LoadData(string query)
        {
            dataGridView1.DataSource = null;
            if (!string.IsNullOrEmpty(query))
            {
                var filtered = itemsList.Where(i => i.Name.ToLower().Contains(query.ToLower())).ToList();
                dataGridView1.DataSource = filtered;
            } else
            {
                dataGridView1.DataSource = itemsList;
            }
            
            dataGridView1.Refresh();
        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            string query = searchtextBox.Text;
            LoadData(query);
        }
    }
}

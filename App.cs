using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Controls;
using InventoryManagementSystem.Models;
using WinFormsApp1;
using WinFormsApp1.Controls;
using WinFormsApp1.Models;


namespace WinFormsApp1
{
    public partial class App : Form
    {
        private Database db;
        private User CurrentUser;
        public App()
        {
            InitializeComponent();
            this.db = new Database("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Huzaifa Farooq\\source\\repos\\WebApplication1\\IMS.mdf\";Integrated Security=True;Connect Timeout=30");
        }

        private void App_Load(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void ShowLogin()
        {
            this.CurrentUser = null;
            LoginControl ctrl = new LoginControl(db);
            ctrl.MainForm = this;
            LoadControl(ctrl);
        }
        private void LoadControl(UserControl control)
        {
            if (CurrentUser == null)
            {
                ButtonsPanel.Hide();
            }
            else
            {
                ButtonsPanel.Show();
                if (CurrentUser.Role != Roles.Administrator)
                {
                    createAccBtn.Enabled = false;
                    delAccBtn.Enabled = false;
                }
            }
            MainContent.Controls.Clear();
            MainContent.Controls.Add(control);
        }

        public void ShowInventory()
        {
            if (CurrentUser == null)
            {
                return;
            }
            LoadControl(new InventoryView(db));
        }

        public void SetUserSession(User user)
        {
            this.CurrentUser = user;
            ShowInventory();
        }

        private void ButtonsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowInventory();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadControl(new SaleControl(db));
        }

        private void createAccBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new CreateAccountControl(db));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CurrentUser = null;
            ShowLogin();
        }

        private void delAccBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new DeleteAccountControl(db, CurrentUser));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace InventoryManagementSystem.Models
{
    internal class Session
    {
        public User user { get; set; }
        public bool IsLoggedIn { get; set; }

        public Session(User user, bool isLoggedIn)
        {
            this.user = user;
            this.IsLoggedIn = isLoggedIn;
        }
    }
}

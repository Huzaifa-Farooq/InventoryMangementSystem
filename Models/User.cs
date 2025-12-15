using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class User
    {
        public string Role { get; private set; }
        public string Username { get; set; }
        public List<string> Permissions { get; private set; }

        public User(string username, string role)
        {
            Username = username;
            Role = role;
            Permissions = new List<string>();

            // assigning permissions
            switch (role)
            {
                case Roles.Administrator:
                    Permissions.Add(PermissionsConstants.CanUpdateStock);
                    Permissions.Add(PermissionsConstants.CanViewStock);
                    Permissions.Add(PermissionsConstants.CanCreateAccount);
                    break;
                case Roles.Cashier:
                    Permissions.Add(PermissionsConstants.CanUpdateStock);
                    Permissions.Add(PermissionsConstants.CanViewStock);
                    break;
                default:
                    break;
            }
        }

        public override string ToString()
        {
            return $"User {{ username='{Username}', role='{Role}' }}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using InventoryManagementSystem.Models;

namespace WinFormsApp1.Models
{
    public class Item : BaseItem
    {
        public string Description { get; set; }
        public int Quantity { get; set; }

        public Item(int id, string name, string description, string category, int quantity, double price)
    : base(id, name, category, price)
        {
            Description = description;
            Quantity = quantity;
        }

        public Item(string name, string description, string category, int quantity, double price)
    : base(0, name, category, price)
        {
            Description = description;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"(id={Id}, name='{Name}', quantity={Quantity}, price={Price})";
        }
    }
}

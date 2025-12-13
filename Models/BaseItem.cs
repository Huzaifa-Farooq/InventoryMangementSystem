using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class BaseItem
    {
        public int Id { get; }
        public string Name { get; }
        public string Category { get; }
        public double Price { get; }

        protected BaseItem(int id, string name, string category, double price)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
        }

        public override string ToString()
        {
            return $"(id={Id}, name='{Name}', category='{Category}', price={Price})";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WinFormsApp1.Models;

namespace InventoryManagementSystem.Models
{
    public class SaleItem : BaseItem
    {

        public int QuantityInBill { get; set; }
        public SaleItem(Item item, int QuantityInBill) : base(item.Id, item.Name, item.Category, item.Price)
        {
            this.QuantityInBill = QuantityInBill;
        }


        public override string ToString()
        {
            return $"(id={Id}, name='{Name}', quantityInBill={QuantityInBill}, price/unit={Price}, total={QuantityInBill * Price})";
        }
    }
}

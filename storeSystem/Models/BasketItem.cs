using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeSystem
{
    public class BasketItem
    {
        public int InventoryId { get; set; }
        public string InventoryName { get; set; }
        public int TotalCount { get; set; } = 1;
        public double TotalPrice { get; set; }

        public BasketItem(int inventoryId, string inventoryName, double totalPrice)
        {
            this.InventoryId = inventoryId;
            this.InventoryName = inventoryName;
            this.TotalPrice = totalPrice;
        }

        public override string ToString()
        {
            return "Pavadinimas: " + InventoryName + "  Kiekis krepšelyje: " + TotalCount + " vienetai";
        }
    }
}

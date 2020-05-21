using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeSystem
{
    public class StoreInventory
    {
        public int Id { get; set; }
        public string InventoryName { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }

        public StoreInventory(int id, string inventoryName, int count, double price, int categoryId)
        {
            this.Id = id;
            this.InventoryName = inventoryName;
            this.Count = count;
            this.Price = price;
            this.CategoryId = categoryId;
        }

        public override string ToString()
        {
            return InventoryName + "  Kaina: "+ Price + " EUR, Kiekis "  + Count;
        }
    }
}

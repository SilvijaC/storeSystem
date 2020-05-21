using storeSystem.Data.Models;
using System.Collections.Generic;

namespace storeSystem.Mappers
{
    public static class StoreInventoryMapper
    {
        public static IList<StoreInventory> Map(IList<Inventory> inventoryList)
        {
            var storeInventoryList = new List<StoreInventory>();

            foreach (var item in inventoryList)
            {
                var mappedItem = Map(item);
                storeInventoryList.Add(mappedItem);
            }

            return storeInventoryList;
        }

        public static StoreInventory Map(Inventory inventory)
        {
            return new StoreInventory(inventory.Id, inventory.InventoryName, inventory.Count, inventory.Price, inventory.CategoryId);
        }
    }
}

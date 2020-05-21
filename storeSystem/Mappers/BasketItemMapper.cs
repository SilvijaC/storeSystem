using storeSystem.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace storeSystem.Mappers
{
    class BasketItemMapper
    {
        public static IList<BasketItem> Map(IList inventoryList)
        {
            var basketItemList = new List<BasketItem>();

            foreach (var item in inventoryList)
            {
                var itemCasting = item as StoreInventory;
                var mappedItem = Map(itemCasting);
                basketItemList.Add(mappedItem);
            }

            return basketItemList;
        }

        public static BasketItem Map(StoreInventory storeInventory)
        {
            return new BasketItem(storeInventory.Id, storeInventory.InventoryName, storeInventory.Price);
        }
    }
}

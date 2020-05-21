using storeSystem.Data.Models;
using System.Collections.Generic;

namespace storeSystem.Mappers
{
    public static class StoreInventoryCategoryMapper
    {
        public static IList<StoreInventoryCategory> Map(IList<Category> categoryList) 
        {
            var storeInventoryCategoryList = new List<StoreInventoryCategory>();

            foreach (var item in categoryList)
            {
                var mappedItem = Map(item);
                storeInventoryCategoryList.Add(mappedItem);
            }

            return storeInventoryCategoryList;
        }

        public static StoreInventoryCategory Map(Category category)
        {
            return new StoreInventoryCategory(category.Id, category.CategoryName);
        }
    }
}

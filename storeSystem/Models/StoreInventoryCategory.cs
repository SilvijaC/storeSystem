using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeSystem
{
    public class StoreInventoryCategory
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public StoreInventoryCategory(int id,string category)
        {
            this.Id = id;
            this.CategoryName = category;
        }

        public override string ToString()
        {
            return CategoryName;
        }
    }
}

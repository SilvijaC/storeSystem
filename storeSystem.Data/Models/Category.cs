using System.ComponentModel.DataAnnotations.Schema;

namespace storeSystem.Data.Models
{
    [Table("Category")]
    public class Category
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }
    }
}

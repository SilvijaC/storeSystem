using System.ComponentModel.DataAnnotations.Schema;


namespace storeSystem.Data.Models
{
    [Table("Inventory")]
    public class Inventory
    {
        public int Id { get; set; }
        public string InventoryName { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
    }
}

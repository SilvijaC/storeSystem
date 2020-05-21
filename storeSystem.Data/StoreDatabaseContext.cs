using storeSystem.Data.Models;
using System.Data.Entity;

namespace storeSystem.Data
{
    public class StoreDatabaseContext : DbContext
    {
        public StoreDatabaseContext() : base("StoreDatabaseContext") {}

        public IDbSet<Category> Categories { get; set; }
        public IDbSet<Inventory> Inventories { get; set; }
        public IDbSet<User> Users { get; set; } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

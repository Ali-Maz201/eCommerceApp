using System.ComponentModel.DataAnnotations;

namespace EntityORM.DbEntities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public decimal ActualCost { get; set; }

        public DateTime Created_At { get; set; }

        public DateTime Modified_At { get; set; }

        public DateTime Deleted_At { get; set; }

        // Navigation Property
        public int CategoryID { get; set; }
        public ProductCategory? Category { get; set; }

        public int DiscountID { get; set; }
        public Discount? Discount { get; set; }

        public int InventoryID { get; set; }
        public ProductInventory? Inventory { get; set; }
    }
}

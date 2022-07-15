namespace EntityORM.DbEntities
{
    public class ProductInventory
    {
        public int Id { get; set; }

        public int Quantity { get; set; } = 0;

        public DateTime Created_At { get; set; }

        public DateTime? Modified_At { get; set; }

        public DateTime? Deleted_At { get; set; }
    }
}

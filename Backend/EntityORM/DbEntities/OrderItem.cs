namespace EntityORM.DbEntities
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public DateTime Created_At { get; set; }

        public DateTime Modified_At { get; set; }

        //Navigation Properties
        public int OrderID { get; set; }
        public Order? Order { get; set; }

        public int ProductID { get; set; }
        public Product? Product { get; set; }
    }
}

namespace EntityORM.DbEntities
{
    public class Order
    {
        public int Id { get; set; }

        public decimal Total { get; set; }

        public DateTime Created_At { get; set; }

        public DateTime Modified_At { get; set; }

        public int PaymentID { get; set; }
        public PaymentDetails? PaymentDetails { get; set; }

    }
}

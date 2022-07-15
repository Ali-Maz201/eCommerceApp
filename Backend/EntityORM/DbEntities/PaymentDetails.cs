namespace EntityORM.DbEntities
{
    public class PaymentDetails
    {
        public int Id { get; set; }

        public int OrderID { get; set; }

        public decimal Ammount { get; set; }

        public string Provider { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

        public DateTime Created_At { get; set; }

        public DateTime Modified_At { get; set; }
    }
}

namespace EntityORM.DbEntities
{
    public class CartItem
    {   
        public int Id { get; set; }

        public int Quantity { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }

        //Navigation Properties
        public int SessionID { get; set; }
        public ShopingSession? CartSession { get; set; }

        public int ProductID { get; set; }
        public Product? ProductInCart { get; set; }
    }
}

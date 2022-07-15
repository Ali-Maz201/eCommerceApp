using EntityORM.DbEntities;
using Microsoft.EntityFrameworkCore;

namespace EntityORM.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Discount>? Discounts { get; set; }
        public DbSet<ProductCategory>? Categories { get; set; }
        public DbSet<ProductInventory>? Inventories { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<OrderItem>? OrderItems { get; set; }
        public DbSet<PaymentDetails>? PaymentsDetail { get; set; }
        public DbSet<CartItem>? CartItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=DESKTOP-7MVUC2L\\SQLEXPRESS; Initial Catalog=ECommerceDB; Integrated Security=SSPI;");
        }
    }
}

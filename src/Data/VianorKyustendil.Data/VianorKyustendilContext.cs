using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VianorKyustendil.Data.Models;

namespace VianorKyustendil.Data
{
    public class VianorKyustendilContext : IdentityDbContext<VianorKyustendilUser>
    {
        public VianorKyustendilContext(DbContextOptions<VianorKyustendilContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<VianorKyustendilUser>()
                .Property(x => x.Country)
                .HasDefaultValue("Bulgaria");

            builder.Entity<OrderDetail>()
                .HasKey(x => new { x.OrderId, x.ProductId });


            base.OnModelCreating(builder);
        }
    }
}

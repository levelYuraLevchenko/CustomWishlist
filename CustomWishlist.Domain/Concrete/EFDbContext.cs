using CustomWishlist.Domain.Entities;
using System.Data.Entity;

namespace CustomWishlist.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}

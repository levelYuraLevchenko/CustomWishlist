using CustomWishlist.Domain.Abstract;
using CustomWishlist.Domain.Entities;
using System.Collections.Generic;


namespace CustomWishlist.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products { get { return context.Products; } }
    }
}

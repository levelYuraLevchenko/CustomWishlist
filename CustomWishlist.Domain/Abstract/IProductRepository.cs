using System.Collections.Generic;
using CustomWishlist.Domain.Entities;
using System.Linq;

namespace CustomWishlist.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}

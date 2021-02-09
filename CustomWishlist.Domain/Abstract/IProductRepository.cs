using System.Collections.Generic;
using CustomWishlist.Domain.Entities;

namespace CustomWishlist.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}

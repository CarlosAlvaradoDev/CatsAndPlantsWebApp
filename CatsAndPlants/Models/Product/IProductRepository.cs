using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatsAndPlants.Models
{
    public interface IProductRepository
    {
        public Product Create(Product product);
        public IQueryable<Product> GetAllProducts();
        public Product GetProductById(int productId);
        public Product Update(Product product);
        public bool Delete(Product product);
    }
}

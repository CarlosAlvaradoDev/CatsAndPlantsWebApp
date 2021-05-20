using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatsAndPlants.Models
{
    public class EfProductRepository : IProductRepository
    {
        // F i e l d s  &  P r o p e r t i e s
        private AppDbContext _context;

        // C o n s t r u c t o r s
        public EfProductRepository(AppDbContext context)
        {
            _context = context;
        }

        // M e t h o d s
        // C r e a t e
        public Product Create(Product p)
        {
            _context.Products.Add(p);
            _context.SaveChanges();
            return p;
        }

        // R e a d
        public IQueryable<Product> GetAllProducts()
        {
            return _context.Products;
        }

        public Product GetProductById(int id)
        {
            //return _context.Products.Find(id); EASY WAY

            return _context.Products
                           .FirstOrDefault(c => c.ProductId == id);
        }

        // U p d a t e
        public Product Update(Product p)
        {
            Product ProductToUpdate = GetProductById(p.ProductId);
            if (ProductToUpdate != null)
            {
                ProductToUpdate.ProductId = p.ProductId;
                ProductToUpdate.Category = p.Category;
                ProductToUpdate.Name = p.Name;
                ProductToUpdate.Description = p.Description;
                ProductToUpdate.Price = p.Price;
                ProductToUpdate.Weight = p.Weight;
                
                _context.SaveChanges();
            }
            return ProductToUpdate;
        }

        // D e l e t e
        public bool Delete(Product p)
        {
            Product ProductToDelete = GetProductById(p.ProductId);
            if (ProductToDelete == null)
            {
                return false;
            }
            _context.Products.Remove(ProductToDelete);
            _context.SaveChanges();
            return true;
        }
    }
}

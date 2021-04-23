using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatsAndPlants.Models
{
    public class EfCustomerRepository : ICustomerRepository
    {
        // F i e l d s  &  P r o p e r t i e s
        private AppDbContext _context;

        // C o n s t r u c t o r s
        public EfCustomerRepository(AppDbContext context)
        {
            _context = context;
        }

        // M e t h o d s

        // R e a d
        public IQueryable<Customer> GetAllCustomers()
        {
            return _context.Customers;
        }

        public Customer GetCustomerById(int id)
        {
            //return _context.Customers.Find(id); EASY WAY

            return _context.Customers.FirstOrDefault(c => c.CustomerId == id);
        }

        // U p d a t e


        // C r e a t e


        // D e l e t e
    }
}

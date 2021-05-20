using Microsoft.EntityFrameworkCore;
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

            return _context.Customers
                           .Include(o => o.Orders)
                           .FirstOrDefault(c => c.CustomerId == id);
        }

        // U p d a t e
        public Customer Update(Customer c)
        {
            Customer customerToUpdate = GetCustomerById(c.CustomerId);
            if (customerToUpdate != null)
            {
                customerToUpdate.FirstName = c.FirstName;
                customerToUpdate.LastName = c.LastName;
                customerToUpdate.Email = c.Email;
                customerToUpdate.Password = c.Password;
                customerToUpdate.Phone = c.Phone;
                customerToUpdate.ShipAddress = c.ShipAddress;
                customerToUpdate.ShipCity = c.ShipCity;
                customerToUpdate.ShipState = c.ShipState;
                customerToUpdate.ShipPostal = c.ShipPostal;
                customerToUpdate.BillAddress = c.BillAddress;
                customerToUpdate.BillCity = c.BillCity;
                customerToUpdate.BillState = c.BillState;
                customerToUpdate.BillPostal = c.BillPostal;
                _context.SaveChanges();
            }
            return customerToUpdate;
        }

        // C r e a t e
        public Customer Create(Customer c)
        {
            _context.Customers.Add(c);
            _context.SaveChanges();
            return c;
        }

        // D e l e t e
        public bool Delete(int id)
        {
            Customer customerToDelete = GetCustomerById(id);
            if (customerToDelete == null)
            {
                return false;
            }
            _context.Customers.Remove(customerToDelete);
            _context.SaveChanges();
            return true;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatsAndPlants.Models
{
    public interface ICustomerRepository
    {
        // C r e a t e
        public Customer Create(Customer c);

        // R e a d
        public IQueryable<Customer> GetAllCustomers();

        public Customer GetCustomerById(int id);

        // U p d a t e
        public Customer Update(Customer c);

        // D e l e t e
        public bool Delete(int id);
    }
}

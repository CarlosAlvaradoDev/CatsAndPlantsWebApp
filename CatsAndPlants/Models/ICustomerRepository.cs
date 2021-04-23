using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatsAndPlants.Models
{
    public interface ICustomerRepository
    {
        // C r e a t e


        // R e a d
        public IQueryable<Customer> GetAllCustomers();

        public Customer GetCustomerById(int id);

        // U p d a t e


        // D e l e t e
    }
}

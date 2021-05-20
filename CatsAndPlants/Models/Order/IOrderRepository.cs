using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatsAndPlants.Models
{
    public interface IOrderRepository
    {
       


        // Methods
        public Order Create(Order o);
        public IQueryable<Order> GetAllOrders(int customerId);
        public Order GetOrderById(int orderId);
        public Order Update(Order order);
        public bool Delete(Order order);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatsAndPlants.Models
{
    public class EfOrderRepository : IOrderRepository
    {
        // Fields and Props
        private AppDbContext _context;

        //Constructors
        public EfOrderRepository(AppDbContext context)
        {
            _context = context;
        }

        //Create
        public Order Create(Order o)
        {
            _context.Orders.Add(o);
            _context.SaveChanges();
            return o;
        }

        //Read
        public IQueryable<Order> GetAllOrders(int customerId)
        {
            return _context.Orders.Where(o => o.CustomerId == customerId);
        }

        public Order GetOrderById(int orderId)
        {
            return _context.Orders.FirstOrDefault(o => o.OrderId == orderId);
        }

        //Update
        public Order Update(Order order)
        {
            Order orderToUpdate = GetOrderById(order.OrderId);
            if (orderToUpdate != null)
            {
                orderToUpdate.OrderDate = order.OrderDate;
                orderToUpdate.OrderId = order.OrderId;
                orderToUpdate.ShipAddress = order.ShipAddress;
                orderToUpdate.ShipAddress = order.ShipAddress;
                orderToUpdate.ShipCity = order.ShipCity;
                orderToUpdate.ShipState = order.ShipState;
                orderToUpdate.ShipPostal = order.ShipPostal;
                orderToUpdate.TotalCost = order.TotalCost;
                _context.SaveChanges();
            }
            return orderToUpdate;
        }
        public bool Delete(Order order)
        {
            Order orderToDelete = GetOrderById(order.OrderId);
            if (orderToDelete == null)
            {
                return false;
            }
            _context.Orders.Remove(orderToDelete);
            _context.SaveChanges();
            return true;
        }
    }
}

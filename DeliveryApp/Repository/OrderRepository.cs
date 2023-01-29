using DeliveryApp.Data;
using DeliveryApp.Interfaces;
using DeliveryApp.Models;

namespace DeliveryApp.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDataContext _context;

        public OrderRepository(OrderDataContext orderDataContext)
        {
            _context = orderDataContext;
        }

        public Order GetOrder(long id)
        {
            return _context.Orders.Where(o => o.OrderId == id).FirstOrDefault() 
                        ?? new Order();
        }

        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders;
        }

        public async Task SaveAsync(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }
    }
}

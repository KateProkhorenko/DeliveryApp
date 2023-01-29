using DeliveryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryApp.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
        Order GetOrder(long id);
        Task SaveAsync(Order order);
    }
}

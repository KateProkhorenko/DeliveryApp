using Microsoft.AspNetCore.Mvc;
using DeliveryApp.Models;
using DeliveryApp.Interfaces;

namespace DeliveryApp.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class OrderController : Controller
    {
        private readonly IOrderRepository repository;

        public OrderController(IOrderRepository orderrepository)
        {
            repository = orderrepository;
        }
        /// <summary>
        /// Get All Orders
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(repository.GetOrders());
        }
        /// <summary>
        /// Get details an order by OrderID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Details(long id)
        {
            Order r = repository.GetOrder(id);
            OrderViewModel model = ViewModelFactory.Details(r);
            
            return View("OrderEditor",model);
        }
        /// <summary>
        /// HTTPGet Method. Create Order
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View("OrderEditor", ViewModelFactory.Create(new Order()));
        }
        /// <summary>
        /// HTTPPost Method. Create Order 
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] Order order)
        {
            if (ModelState.IsValid)
            {
                order.OrderId = default;
                await repository.SaveAsync(order);
                return RedirectToAction(nameof(Index));
            }
            return View("OrderEditor", ViewModelFactory.Create(order));
        }
    }
}

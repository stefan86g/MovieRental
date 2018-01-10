using BOLMovieRent.Movies;
using DBMovieRent;
using MovieRental.Mappers;
using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRental.Controllers
{
    public class OrderController : Controller
    {
        private OrderService orderService;

        public OrderController()
        {
            orderService = new OrderService();
        }

        // Get all orders
        [HttpGet]
        public ActionResult GetOrders()
        {
            IEnumerable<Order> orders = orderService.GetAllOrders();
            List<OrderViewModel> ordersVMs = new List<OrderViewModel>();
            foreach (Order order in orders)
            {
                OrderViewModel movieVM = OrderMapper.OrderMapModelToViewModel(order);
                ordersVMs.Add(movieVM);
            }

            return View(ordersVMs);
        }

        //Add Order to DB
        [HttpGet]
        public ActionResult AddOrder(string title)
        {
            string UserEmail = HttpContext.User.Identity.Name;

            OrderViewModel OrderModel = new OrderViewModel();
            OrderModel.Title = title;
            OrderModel.Email = UserEmail;
            OrderModel.OrderDate = DateTime.Now;
            DBMovieRent.Order order = OrderMapper.OrderMapViewModelToModel(OrderModel);
            this.orderService.AddOrderService(order);

            this.orderService.ChangeAvailAbility(title);

            return RedirectToRoute(new { controller = "Movie", action = "GetMovies" });
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBMovieRent;

namespace BOLMovieRent.Movies
{
    public class OrderService
    {

        //get all Orders
        public IEnumerable<DBMovieRent.Order> GetAllOrders()
        {
            IEnumerable<DBMovieRent.Order> orders;
            using (OrderRepository ordersRepository = new OrderRepository())
            {
                orders = ordersRepository.GetAllOrdersRepository();
            }
            return orders;
        }

        //add Order
        public void AddOrderService(DBMovieRent.Order orderVM)
        {

            using (OrderRepository orderRepository = new OrderRepository())
            {
                orderRepository.AddtOrdertoDB(orderVM);
            }
        }

    }
}

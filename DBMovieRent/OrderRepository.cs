using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMovieRent
{
    public class OrderRepository : IDisposable
    {
        private DataMovieRentEntities context;
        private DbSet<Order> orders;


        public OrderRepository()
        {
            context = new DataMovieRentEntities();
            orders = context.Orders;
        }

        //Get All Orders
        public IEnumerable<Order> GetAllOrdersRepository()
        {
            return orders.ToList();
        }



        //Add order to database
        public void AddtOrdertoDB(Order order)
        {

            orders.Add(order);
            context.SaveChanges();
        }

        // set a movie availability
        public void SetAvailAbility(string tilte)
        {
            Movie movie = context.Movies1.FirstOrDefault(c => c.Title == tilte);
            if (movie != null)
            {

                movie.Availability = "Not Available";

                context.SaveChanges();
            }

        }


        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
            }
        }

    }
}

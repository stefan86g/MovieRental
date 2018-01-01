using DBMovieRent;
using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental.Mappers
{
    public class OrderMapper
    {
        //User model To ViewModel
        public static OrderViewModel OrderMapModelToViewModel(Order order)
        {
            OrderViewModel orderVM = new OrderViewModel();

            orderVM.Email = order.Email;
            orderVM.Title = order.Title;
            orderVM.OrderDate = Convert.ToDateTime(order.OrderDate);
            return orderVM;
        }

        //ViewModel To User Model
        public static DBMovieRent.Order OrderMapViewModelToModel(OrderViewModel orderVM)
        {
            DBMovieRent.Order order = new DBMovieRent.Order();

            order.Email = orderVM.Email;
            order.Title = orderVM.Title;
            order.OrderDate = orderVM.OrderDate;

            return order;
        }
    }
}
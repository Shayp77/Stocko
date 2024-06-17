using StockoApp.Controller;
using StockoApp.Handler;
using StockoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Controller
{
    public class CartController
    {
        public static void InsertToCart(int userId, int tid, int quantity)
        {
            CartHandler handler = new CartHandler();
            int id = OrderController.generateid();

            handler.InsertToCart(id, userId, tid, quantity);
        }
        public static List<Cart> getallcart()
        {
            CartHandler h = new CartHandler();
            return h.GetAllCartItems();
        }
    }
}
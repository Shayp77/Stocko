using StockoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Factory
{
    public class CartFactory
    {
        public static Cart create(int id, int userid, int itemid, int quantity)
        {
            Cart cart = new Cart();
            cart.CartID = id;
            cart.UserID = userid;
            cart.ItemID = itemid;
            cart.Quantity = quantity;
            return cart;
        } 
    }
}
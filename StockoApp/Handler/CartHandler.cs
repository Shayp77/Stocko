using StockoApp.Models;
using StockoApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Handler
{
    public class CartHandler
    {
        private readonly CartRepo _cartRepo;

        public CartHandler()
        {
            _cartRepo = new CartRepo();
        }

        public void InsertToCart(int id, int userid, int did, int quantity)
        {
            _cartRepo.insert(id, userid, did, quantity);
        }

        public void DeleteAllItemsFromCart()
        {
            _cartRepo.deleteAll();
        }

        public Cart GetLastCartItem()
        {
            return _cartRepo.getlastcart();
        }

        public List<Cart> GetAllCartItems()
        {
            return _cartRepo.getallcart();
        }

    }
}
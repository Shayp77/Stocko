using StockoApp.Factory;
using StockoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Repository
{
    public class CartRepo
    {
        StockoEntities db = DatabaseSingleton.getinstance();
        public void insert(int id, int userid, int itemid, int quantity)
        {
            Cart cart = CartFactory.create(id, userid, itemid, quantity);
            db.Carts.Add(cart);
            db.SaveChanges();
        }
        public void deleteAll()
        {
            db.Carts.RemoveRange(db.Carts);
            db.SaveChanges();
        }
        public Cart getlastcart()
        {
            return db.Carts.ToList().LastOrDefault();
        }
        public List<Cart> getallcart()
        {
            return db.Carts.ToList();
        }
    }
}
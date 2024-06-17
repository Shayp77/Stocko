using StockoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Factory
{
    public class ItemFactory
    {
        public static Item create(int id, string name, int price, int type, int user)
        {
            Item item = new Item();
            item.UserID =user;
            item.ItemID =id;
            item.ItemName =name;
            item.ItemPrice =price;
            item.ItemTypeID =type;
            return item;
        }
    }
}
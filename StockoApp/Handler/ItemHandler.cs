using StockoApp.Factory;
using StockoApp.Models;
using StockoApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Handler
{
    public class ItemHandler
    {
        public static List<Item> getAllItems()
        {
            return ItemRepo.getAllItems();
        }
        public static List<Item> getbyuserid(int id)
        {
            return ItemRepo.getbyuserid(id);
        }
        public static int getlastitemid()
        {
            return ItemRepo.getlastitemid();
        }

        public static void insertItem(String name, int price,
            int typeid, int userid)
        {
             ItemRepo.insertItem(name, price, typeid, userid);
        }

        public static void RemoveItembyid(int id)
        {
             ItemRepo.RemoveItembyid(id);
        }

        public static Item finditembyid(int id)
        {
            return ItemRepo.finditembyid(id);
        }

        
        public static void updateItem(int id, String name, int price, int typeid)
        {
            ItemRepo.updateitem(id,name, price , typeid);
        }
    }
}
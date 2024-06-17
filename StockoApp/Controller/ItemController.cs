using StockoApp.Handler;
using StockoApp.Models;
using StockoApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Controller
{
    public class ItemController
    {
        public static List<ItemType> getAllItemType()
        {
            return ItemTypeHandler.getAllItemType();
        }

        public static int getlastitemtypeid()
        {
            return ItemTypeHandler.getlastitemtypeid();
        }

        public static List<int> getallitemtypeid()
        {
            return ItemTypeHandler.getallitemtypeid();
        }
        public static int generateTypeID()
        {
            return ItemTypeHandler.generateItemTypeID();
        }
        public static void inserttype(int id, String name)
        {
            ItemTypeHandler.inserttype(id, name);
        }

        public static ItemType finditemtypebyid(int id)
        {
            return ItemTypeHandler.finditemtypebyid(id);
        }

        public static void removeitemtypebyid(int id)
        {
            ItemTypeHandler.removeitemtypebyid(id);
        }

        public static void updateitemtype(int id, String name)
        {
            ItemTypeHandler.updateitemtype(id, name);
        }

        public static int getitemtypeidbyname(String name)
        {
            return ItemTypeHandler.getitemtypeidbyname(name);
        }
        public static List<Item> getAllItems()
        {
            return ItemHandler.getAllItems();
        }

        public static int getlastitemid()
        {
            return ItemHandler.getlastitemid();
        }
        public static List<Item> getbyuserid(int id)
        {
            return ItemHandler.getbyuserid(id);
        }
        public static void insertItem(String name, int price,
            int typeid, int userid)
        {
                ItemHandler.insertItem(name,price, typeid, userid);
        }

        public static void RemoveItembyid(int id)
        {
            ItemHandler.RemoveItembyid(id);
        }

        public static Item finditembyid(int id)
        {
            return ItemHandler.finditembyid(id);
        }
        public static void updateItem(int id, String name, int price, int typeid)
        {
            ItemHandler.updateItem(id,name, price, typeid );
        }
        public static string ItemValidation(string name, int price, int typeid)
        {
            string errmess = "";
            if (name.Length < 1 || name.Length > 99)
            {
                errmess = "Please fill the Name between 1 to 99 characters";
            }
            else if (price < 1)
            {
                errmess = "Price should be greater than or equal to 1";
            }
            else if (typeid == 0)
            {
                errmess = "Type ID cannot be empty";
            }
            return errmess;
        }
        public static string ItemTypeValidation(string name)
        {
            string errmess = "";
            if (name.Length < 1 || name.Length > 99)
            {
                errmess = "Please fill the TypeName Name between 1 to 99 characters";
            }
            return errmess;
        }
    }
}
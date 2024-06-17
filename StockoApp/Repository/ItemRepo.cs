using StockoApp.Factory;
using StockoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Repository
{
    public class ItemRepo
    {
       private static StockoEntities db = DatabaseSingleton.getinstance();
        public static List<Item> getAllItems()
        {
            return db.Items.ToList();
        }

        public static int getlastitemid()
        {
            return (from x in db.Items select x.ItemID).ToList().LastOrDefault();
        }

        public static void insertItem(String name, int price,
            int typeid,int userid)
        {
            int newID = 0;
            int lastID = (from x in db.Items select x.ItemID).ToList().LastOrDefault();

            if (db == null)
            {
                newID = 1;
            }
            else
            {
                newID = lastID + 1;
            }

            Item item = ItemFactory.create(newID, name, price,
                typeid,userid);
            db.Items.Add(item);
            db.SaveChanges();
        }

        public static void RemoveItembyid(int id)
        {
            TransactionDetailRepo td = new TransactionDetailRepo();
            List<TransactionDetail> tList = td.FindByItemID(id);
            foreach (var t in tList)
            {
                db.TransactionDetails.Remove(t);
            }
            db.SaveChanges();
            Item item = db.Items.Find(id);
            db.Items.Remove(item);
            db.SaveChanges();
        }

        public static Item finditembyid(int id)
        {
            Item item = db.Items.Find(id);
            return item;
        }

        
        public static void updateitem(int id, String name, int price, int typeid)
        {
            Item item = finditembyid (id);
            item.ItemName = name;
            item.ItemPrice = price;
            item.ItemTypeID = typeid;
            db.SaveChanges();
        }
        public static List<Item> getbyuserid(int id)
        {
            return (from x in db.Items where x.UserID == id select x).ToList();
        }
        
    }
}
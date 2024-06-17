using StockoApp.Factory;
using StockoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Repository
{
    public class ItemTypeRepo
    {
        private static StockoEntities db = DatabaseSingleton.getinstance();
        public static List<ItemType> getAllItemType()
        {
            return db.ItemTypes.ToList();
        }

        public static int getlastitemtypeid()
        {
            return (from x in db.ItemTypes select x.ItemTypeID).ToList().LastOrDefault();
        }

        public static List<int> getallitemtypeid ()
        {
            return (from x in db.ItemTypes select x.ItemTypeID).ToList();
        }

        public static void inserttype(int tid, String name)
        {
            ItemType item = ItemTypeFactory.create(tid, name);
            db.ItemTypes.Add(item);
            db.SaveChanges();
        }

        public static ItemType finditemtypebyid(int tid)
        {
            ItemType item = db.ItemTypes.Find(tid);
            return item;
        }

        public static void removeitemtypebyid(int tid)
        {
            ItemType item = db.ItemTypes.Find(tid);
            db.ItemTypes.Remove(item);
            db.SaveChanges();
        }

        public static void updateitemtype(int id, String name)
        {
            ItemType item = finditemtypebyid(id);
            item.ItemTypeID = id;
            item.TypeName = name;
            db.SaveChanges();
        }

        public static int getitemtypeidbyname(String name)
        {
            return (from x in db.ItemTypes
                    where x.TypeName == name
                    select x.ItemTypeID).FirstOrDefault();
        }
        public static int generateItemTypeID()
        {
            int newID = 0;
            int lastID = ItemTypeRepo.getlastitemtypeid();
            int? lastIDLogic = lastID;
            if (lastIDLogic == null)
            {
                newID = 1;
            }
            else
            {
                newID = lastID;
                newID++;
            }
            return newID;
        }
    }
}
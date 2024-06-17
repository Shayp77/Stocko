using StockoApp.Factory;
using StockoApp.Models;
using StockoApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Handler
{
    public class ItemTypeHandler
    {
        public static List<ItemType> getAllItemType()
        {
            return ItemTypeRepo.getAllItemType();
        }

        public static int getlastitemtypeid()
        {
            return ItemTypeRepo.getlastitemtypeid();
        }

        public static List<int> getallitemtypeid()
        {
            return ItemTypeRepo.getallitemtypeid();
        }

        public static void inserttype(int id, String name)
        {
            ItemTypeRepo.inserttype(id, name);
        }

        public static ItemType finditemtypebyid(int id)
        {
            return ItemTypeRepo.finditemtypebyid(id);
        }

        public static void removeitemtypebyid(int id)
        {
            ItemTypeRepo.removeitemtypebyid(id);
        }

        public static void updateitemtype(int id, String name)
        {
            ItemTypeRepo.updateitemtype(id  , name);
        }

        public static int getitemtypeidbyname(String name)
        {
            return ItemTypeRepo.getitemtypeidbyname(name);
        }
        public static int generateItemTypeID()
        {
            return ItemTypeRepo.generateItemTypeID();
        }
    }
}
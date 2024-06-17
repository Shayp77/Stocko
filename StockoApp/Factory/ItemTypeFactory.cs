using StockoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Factory
{
    public class ItemTypeFactory
    {
        public static ItemType create(int id, string name)
        {
            ItemType itemType = new ItemType();
            itemType.ItemTypeID = id;
            itemType.TypeName = name;
            return itemType;
        }
    }
}
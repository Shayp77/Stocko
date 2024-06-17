using StockoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Repository
{
    public class DatabaseSingleton
    {
        private static StockoEntities db = null;
        public static StockoEntities getinstance()
        {
            if (db == null)
            {
                db = new StockoEntities();
            }
            return db;
        }
    }
}
using StockoApp.Factory;
using StockoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Repository
{
    public class TransactionDetailRepo
    {
        StockoEntities db = DatabaseSingleton.getinstance();
        public void inserttd(int tid, int mid, int quantity)
        {
            TransactionDetail td = TransactionDetailsFactory.create(tid, mid, quantity);
            db.TransactionDetails.Add(td);
            db.SaveChanges();

        }

        public List<TransactionDetail> FindByTransactionId(int tid)
        {
            return db.TransactionDetails.Where(t => t.TransactionID == tid).ToList();
        }
        public List<TransactionDetail> FindByItemID(int tid)
        {
            return db.TransactionDetails.Where(t => t.ItemID == tid).ToList();
        }
        public List<TransactionDetail> getAllTransactionDetails()
        {
            return db.TransactionDetails.ToList();
        }

    }
}
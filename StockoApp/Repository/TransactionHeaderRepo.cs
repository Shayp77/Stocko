using StockoApp.Controller;
using StockoApp.Factory;
using StockoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Repository
{
    public class TransactionHeaderRepo
    {
        StockoEntities db = DatabaseSingleton.getinstance();
        public void insertheader(int tid, int uid, DateTime dt)
        {

            TransactionHeader th = TransactionHeaderFactory.create(tid, uid, dt);
            db.TransactionHeaders.Add(th);
            db.SaveChanges();

        }
        public TransactionHeader getTransactionbyid(int TransactionID)
        {
            TransactionHeader th = db.TransactionHeaders.Find(TransactionID);
            return th;
        }
        public List<TransactionHeader> getbyuserid(int id)
        {
            return db.TransactionHeaders.Where(t => t.UserID == id).ToList();

        }
        public List<TransactionHeader> getAllTransactionHeaders()
        {
            return db.TransactionHeaders.ToList();
        }

        public TransactionHeader getlasttransaction()
        {
            return db.TransactionHeaders.ToList().LastOrDefault();
        }
       
        public TransactionHeader search(int tid)
        {
            return (from TransactionHeader in db.TransactionHeaders where TransactionHeader.TransactionID == tid select TransactionHeader).FirstOrDefault();
        }
        
        
        public static int generatetransactionid()
        {
            TransactionHController tc = new TransactionHController();
            TransactionHeader th = tc.GetLastTransaction();
            if (th == null)
            {
                return 1;
            }
            int id = th.TransactionID;
            id++;
            return id;
        }
    }
}
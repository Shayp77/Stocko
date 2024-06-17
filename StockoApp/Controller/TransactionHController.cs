using StockoApp.Handler;
using StockoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Controller
{
    public class TransactionHController
    {
        TransactionHeaderHandler th = new TransactionHeaderHandler();
        public List<TransactionHeader> getAllTransactionHeaders()
        {
            return th.getAllTransactionHeaders();
        }
        public void InsertTransactionHeader(int tid, int userid, DateTime dt)
        {
            th.InsertTransactionHeader(tid, userid, dt);
        }
        public List<TransactionHeader> getbyuserid(int id)
        {
            return th.getbyuserid(id);

        }
        
        public TransactionHeader search(int tid)
        {
            return th.search(tid);
        }
        
        public TransactionHeader GetLastTransaction()
        {
            return th.GetLastTransaction();
        }
        public static int generatetransactionid()
        {
            return TransactionHeaderHandler.generatetransactionid();
        }
    }
}
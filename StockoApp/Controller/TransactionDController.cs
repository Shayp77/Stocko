using StockoApp.Handler;
using StockoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Controller
{
    public class TransactionDController
    {
        public void InsertTransactionDetail(int tid, int id, int quantity)
        {

            TransactionDetailHandler transactionDetailHandler = new TransactionDetailHandler();
            transactionDetailHandler.InsertTransactionDetail(tid, id, quantity);
        }
        public static List<TransactionDetail> getAllTransactionDetails()
        {
            TransactionDetailHandler transactionDetailHandler = new TransactionDetailHandler();

            return transactionDetailHandler.getAllTransactionDetails();
        }
        public static List<TransactionDetail> FindByTransactionId(int tid)
        {
            TransactionDetailHandler transactionDetailHandler = new TransactionDetailHandler();

            return transactionDetailHandler.FindByTransactionId(tid);
        }
    }
}
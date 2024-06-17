using StockoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader create(int tid, int uid, DateTime dt)
        {
            TransactionHeader transactionHeader = new TransactionHeader();
            transactionHeader.TransactionID = tid;
            transactionHeader.UserID = uid;
            transactionHeader.TransactionDate = dt;
            return transactionHeader;
        }
    }
}
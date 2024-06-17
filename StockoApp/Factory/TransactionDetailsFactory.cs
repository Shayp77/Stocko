using StockoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Factory
{
    public class TransactionDetailsFactory
    {
        public static TransactionDetail create(int tid, int mid, int quantity)
        {
            TransactionDetail transactionDetail = new TransactionDetail();
            transactionDetail.TransactionID = tid;
            transactionDetail.ItemID = mid;
            transactionDetail.Quantity = quantity;
            return transactionDetail;
        }
    }
}
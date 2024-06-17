using StockoApp.Models;
using StockoApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Handler
{
    public class TransactionDetailHandler
    {
        private readonly TransactionDetailRepo _transactionDetailRepo;

        public TransactionDetailHandler()
        {
            _transactionDetailRepo = new TransactionDetailRepo();
        }

        public void InsertTransactionDetail(int tid, int mid, int quantity)
        {
            _transactionDetailRepo.inserttd(tid, mid, quantity);
        }

        public List<TransactionDetail> getAllTransactionDetails()
        {
            return _transactionDetailRepo.getAllTransactionDetails();
        }
        public List<TransactionDetail> FindByTransactionId(int tid)
        {
            return _transactionDetailRepo.FindByTransactionId(tid);
        }
    }
}
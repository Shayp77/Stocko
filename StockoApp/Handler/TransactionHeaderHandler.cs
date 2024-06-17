using StockoApp.Models;
using StockoApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Handler
{
    public class TransactionHeaderHandler
    {
        private readonly TransactionHeaderRepo _transactionHeaderRepo;

        public TransactionHeaderHandler()
        {
            _transactionHeaderRepo = new TransactionHeaderRepo();
        }

        public void InsertTransactionHeader(int tid, int uid, DateTime dt)
        {
            _transactionHeaderRepo.insertheader(tid, uid, dt);
        }

        public TransactionHeader GetLastTransaction()
        {
            return _transactionHeaderRepo.getlasttransaction();
        }
        public List<TransactionHeader> getbyuserid(int id)
        {
            return _transactionHeaderRepo.getbyuserid(id);

        }
        public List<TransactionHeader> getAllTransactionHeaders()
        {
            return _transactionHeaderRepo.getAllTransactionHeaders();
        }
        
        public TransactionHeader search(int tid)
        {
            return _transactionHeaderRepo.search(tid);
        }
        

        
        public static int generatetransactionid()
        {
            return TransactionHeaderRepo.generatetransactionid();
        }
    }
}
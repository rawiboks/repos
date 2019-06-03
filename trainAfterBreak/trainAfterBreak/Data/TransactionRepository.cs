using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using trainAfterBreak.Models;

namespace trainAfterBreak.Data
{
    public class TransactionRepository
    {
        public List<Transaction> ReturnTransactions(int id)
        {
            List<Transaction> transactions;
            transactions = Data.transaction
                .Where(t => t.product.Id == id)
                .OrderBy(t => t.TransactionDate)
                .ToList();
            return transactions;
        }
    }
}
using Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_System.Data
{
    public class TransactionRepository
    {
        Context context = new Context();

        public List<Transaction> GetAllTransactions()
        {
            return context.Transaction.ToList();
            //var transactions = Data.Transactions;
            //return transactions;
        } 

        public List<Transaction> GetProductTransactions(int id)
        {
            return context.Transaction
                .Where(m => m.Product.Id == id)
                .OrderByDescending(m => m.TransactionDate)
                .ToList();
            //var transactions =Data.Transactions.Where(t => t.Product.Id == id).OrderByDescending(t=>t.TransactionDate).ToList();
            //return transactions;

        }

        public void AddTransaction(int id, int quantity)
        {
            Transaction transaction = new Transaction();
            transaction.Id = context.Transaction.Max(t => t.Id)+1;
            transaction.TransactionDate = DateTime.Now;
            transaction.Product = context.Product.Where(p => p.Id == id).SingleOrDefault();
            transaction.Quantity = quantity;

            context.Transaction.Add(transaction);
            context.SaveChanges();
        }

        public List<Transaction> SearchTransactions(int id, int searchMin, int searchMax)
        {
            return context.Transaction.Where(t => t.Quantity >= searchMin).ToList();
            //var transactions = Data.Transactions.Where(t => t.Quantity >= searchMin).ToList();
            //return transactions;
        }
    }
}
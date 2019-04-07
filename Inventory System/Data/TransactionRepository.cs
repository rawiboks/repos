using Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_System.Data
{
    public class TransactionRepository
    {
        public List<Transaction> GetAllTransactions()
        {
            var transactions = Data.Transactions;
            return transactions;
        } 

        public List<Transaction> GetProductTransactions(int id)
        {
            var transactions =Data.Transactions.Where(t => t.Product.Id == id).OrderByDescending(t=>t.TransactionDate).ToList();
            return transactions;

        }

        public void AddTransaction(int id, int quantity)
        {
            Transaction transaction = new Transaction();
            transaction.Id = Data.Transactions.Max(t => t.Id)+1;
            transaction.TransactionDate = DateTime.Now;
            transaction.Product = Data.Products.Where(p => p.Id == id).SingleOrDefault();
            transaction.Quantity = quantity;
            Data.Transactions.Add(transaction);
        }

        public List<Transaction> SearchTransactions(int id, int searchMin, int searchMax)
        {
            var transactions = Data.Transactions.Where(t => t.Quantity >= searchMin).ToList();
            return transactions;
        }
    }
}
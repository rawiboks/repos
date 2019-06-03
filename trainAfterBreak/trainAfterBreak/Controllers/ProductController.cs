using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using trainAfterBreak.Data;
using trainAfterBreak.Models;

namespace trainAfterBreak.Controllers
{
    public class ProductController:Controller
    {
        public ProductRepository Products = new ProductRepository();
        public TransactionRepository Transactions = new TransactionRepository();
        public ManufacturerRepository Manufacturers = new ManufacturerRepository();

        public ActionResult Index()
        {
            return View(Products.ReturnProducts());
        }

        public ActionResult Detail(int id)
        {
            List<Transaction> transactions = Transactions.ReturnTransactions(id);
            ViewBag.transactions = transactions;

            var balance = transactions.Sum(t => t.Quantity);
            ViewBag.Balance= balance;

            return View(Products.ReturnProduct(id));
        }

        public ActionResult Add()
        {
            ViewBag.Manufacturerist = new SelectList
                (Manufacturers.ReturnManufacturers(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult AddManufacturer(string manufacturerName, string address)
        {
            Manufacturers.AddManufacturer(manufacturerName, address);
            return Redirect("Add");
        }

        [HttpPost]
        public ActionResult Add(Models.Product product, int ManufacturerId, HttpPostedFileBase picture)
        {
            string imagePath = "";
            imagePath = Path.Combine(Server.MapPath("~/Images/"), product.Name + ".jpg");
            picture.SaveAs(imagePath);

            Products.AddProduct(product, ManufacturerId);
            ViewBag.Manufacturerist = new SelectList
                (Manufacturers.ReturnManufacturers(), "Id", "Name");
            return Redirect("Index");
        }

    }
}
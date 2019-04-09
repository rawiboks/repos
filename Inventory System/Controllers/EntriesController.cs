using Inventory_System.Data;
using Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Inventory_System.Controllers
{
    public class EntriesController : Controller
    {
        private ProductsRepository _productsRepository = null;
        private ManufacturerRepository _manufacturerRepository = null;
        private TransactionRepository _transactionsRepostiory=null;
        Context context = new Context();

        public EntriesController()
        {
            _productsRepository = new ProductsRepository();
            _manufacturerRepository = new ManufacturerRepository();
            _transactionsRepostiory = new TransactionRepository();
        }
        
        // GET: Entries
        public ActionResult Index()
        {
            return View(_productsRepository.GetProducts());
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var productDetail = _productsRepository.GetProduct(id.Value);
            var transactions = _transactionsRepostiory.GetProductTransactions(id.Value);
            ViewBag.Transactions = transactions;
            ViewBag.Balance = transactions.Sum(t => t.Quantity);
            return View(productDetail);
        }

        [HttpPost]
        public ActionResult AddTransaction(int id, int quantity)
        {
            if ((ModelState.IsValid && quantity != 0))
            {
                _transactionsRepostiory.AddTransaction(id, quantity);
            }

            return RedirectToAction("Detail", new { id = id });
        }

        [HttpPost]
        public ActionResult Detail(int? id, int searchMin, int searchMax)
        {
            var productDetail = _productsRepository.GetProduct(id.Value);
            var transactions = _transactionsRepostiory.SearchTransactions(id.Value, searchMin, searchMax);
            ViewBag.Transactions = transactions;
            ViewBag.Balance = transactions.Sum(t => t.Quantity);
            return View(productDetail);
            //return RedirectToAction("Detail", new { id = id });
        }

        public ActionResult Add()
        {
            ViewBag.ManufacturersSelectListItems = new SelectList(
                context.Manufacturer, "Id", "ManufacturerName");
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product product, HttpPostedFileBase picture)
        {
            if (ModelState.IsValid) /*&& product.Picture != null)*/
            {
                string newFileName = "";
                string imagePath = "";

                newFileName = Guid.NewGuid().ToString() + " " 
                    + Path.GetFileName(picture.FileName);
                newFileName = Path.GetFileName(picture.FileName);
                imagePath = Path.Combine(Server.MapPath("~/Images/"), newFileName);
                picture.SaveAs(imagePath);

                product.Picture = "~/Images/" + newFileName;
                _productsRepository.AddProduct(product);
                return Redirect("Index");
            }

            ViewBag.ManufacturersSelectListItems = new SelectList(
                Data.Data.Manufacturers, "Id", "Name");

            return View(product);
        }

        [HttpPost]
        public ActionResult AddManufacturer(Manufacturer manufacturer)
        {
            _manufacturerRepository.AddManufacturer(manufacturer);

            return Redirect("Add");
        }
    }
}
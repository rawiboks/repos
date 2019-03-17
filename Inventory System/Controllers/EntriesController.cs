using Inventory_System.Data;
using Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Inventory_System.Controllers
{
    public class EntriesController : Controller
    {
        private ProductsRepository _productsRepository = null;
        //private ManufacturerRepository _manufacturerRepository = null;

        public EntriesController()
        {
            _productsRepository = new ProductsRepository();
            //_manufacturerRepository = new ManufacturerRepository();
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
            return View(productDetail);
        }

        public ActionResult Add()
        {
            var product = new Product()
            {
                Name="TestName"
            };

            ViewBag.ManufacturersSelectListItems = new SelectList(
                Data.Data.Manufacturers, "Id", "Name");
            return View(product);
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            ViewBag.ManufacturersSelectListItems = new SelectList(
                Data.Data.Manufacturers, "Id", "Name");

            return View(product);
        }


        public ActionResult testPage()
        {
            return View(); 
        }

        [ActionName("testPage"), HttpPost]
        public ActionResult testPagee(testClass x)
        {
            return View(x);
        }

        public ActionResult testIPage2()
        {
            return View();
        }
    }
}
using Inventory_System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory_System.Controllers
{
    public class EntriesController : Controller
    {
        private ProductsRepository _productsRepository = null;
        private ManufacturerRepository _manufacturerRepository = null;

        public EntriesController()
        {
            _productsRepository = new ProductsRepository();
            _manufacturerRepository = new ManufacturerRepository();
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
            return View(_manufacturerRepository.GetManufacturers());
        }
    }
}
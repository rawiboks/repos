using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WbeForm.Controllers
{
    public class FormController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
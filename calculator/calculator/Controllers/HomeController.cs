using NCalc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace calculator.Controllers
{
    public class HomeController : Controller
    {
        static double hold;
        static string sign;
        static string[] myOperator = new string[] {"+", "-", "/", "*", "="};

        public ActionResult Index()
        {
            ViewBag.total = 0;
            return View();
        }

        [HttpPost]
        public ActionResult Index(string btn, string total)
        {
            //myOperator == null ? myOperator = btn:;
            if (myOperator.Any(o=> o==btn ))
            {
                switch (sign)
                {
                    case "+":
                        if(double.TryParse(total, out hold))
                        {
                            total = "";
                            ViewBag.total = total;
                        }
                        break;
                    case "-":
                        hold -= double.Parse(total);
                        total = "";
                        ViewBag.total = total;
                        break;
                    case "*":
                        hold *= double.Parse(total);
                        total = "";
                        ViewBag.total = total;
                        break;
                    case "/":
                        hold /= double.Parse(total);
                        total = "";
                        ViewBag.total = total;
                        break;
                    case "=":
                        //hold = double.Parse(total);
                        total = "";
                        ViewBag.total = total;
                        break;
                    default:
                        hold = double.Parse(total);
                        ViewBag.total2 = total;
                        break;
                }
                sign = btn;
            }
            else
            {
                ViewBag.total += total + btn;
                if (total == "0")
                    ViewBag.total = btn;
            }

            ViewBag.total2 = hold;
            return View();
        }
    }
}
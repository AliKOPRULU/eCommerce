using eCommerce.DAL.Data;
using eCommerce.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CustomerRepository customer = new CustomerRepository(new DataContext());
            ProductRepository product = new ProductRepository(new DataContext());
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.8811257127 ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L02.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public string Index()
        {
            return "Products/Index is displayed.";
        }

        public string Browse()
        {
            return $"Browse displayed";
        }

        public string Details(int id)
        {
            return $"Details displayed for id={id}";
        }

        public string Location(string zip)
        {
            return HttpUtility.UrlEncode($"Products/Location?zip={zip}");
        }
    }
}
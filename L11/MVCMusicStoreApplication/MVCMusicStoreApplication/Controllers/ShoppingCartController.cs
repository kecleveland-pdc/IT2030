using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStoreApplication.Models.ViewModels;
using MVCMusicStoreApplication.Models;

namespace MVCMusicStoreApplication.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext); // session variable
            ShoppingCartViewModel vm = new ShoppingCartViewModel()
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetCartTotal()
            };

            return View(vm);
        }

        //GET: /ShoppingCart/AddToCart/5
        public ActionResult AddToCart()
        {
            return View();
        }

        //Ajax Call
        //POST: /ShoppingCart/RemoveFromCart/5
        [HttpPost]
        public ActionResult RemoveFromCart()
        {
            return View();
        }
    }
}
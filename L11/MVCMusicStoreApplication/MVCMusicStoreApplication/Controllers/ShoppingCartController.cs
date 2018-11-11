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
        MVCMusicStoreDB dbContext = new MVCMusicStoreDB();
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
        public ActionResult AddToCart(int id)
        {
            //id is AlbumId
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);
            cart.AddToCart(id);
            return RedirectToAction("Index");
        }

        //Ajax Call
        //POST: /ShoppingCart/RemoveFromCart/5
        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            //id == RecordId
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);
            string albumTitle = dbContext.Carts.SingleOrDefault(c => c.RecordID == id).AlbumSelected.Title;
            int ItemCnt = cart.RemoveFromCart(id);

            ShoppingCartRemoveViewModel vm = new ShoppingCartRemoveViewModel()
            {
                ItemCount = ItemCnt,
                DeleteId = id,
                CartTotal = cart.GetCartTotal(),
                Message = $"{albumTitle} has been removed from your cart."
            };


            //creates JSON result
            return Json(vm);  // --> just updating portion of view
        }
    }
}
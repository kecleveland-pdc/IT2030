using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EventFinder.Models;
using EventFinder.Models.ViewModels;

namespace EventFinder.Controllers
{
    public class EventFinderCartsController : Controller
    {
        EventFinderDB dbContext = new EventFinderDB();
        // GET: ShoppingCart
        public ActionResult Index()
        {
            EventFinderEventShoppingCart cart = EventFinderEventShoppingCart.GetCart(this.HttpContext); // session variable
            EventFinderCartViewModel vm = new EventFinderCartViewModel()
            {
                CartItems = cart.GetCartItems(),
            };

            return View(vm);
        }

        public ActionResult OrderSummary()
        {
            EventFinderEventShoppingCart cart = EventFinderEventShoppingCart.GetCart(this.HttpContext); // session variable
            EventFinderCartViewModel vm = new EventFinderCartViewModel()
            {
                CartItems = cart.GetCartItems(),
            };

            return View(vm);
        }

        //GET: /EventFinderCart/Register/5
        // GET: EventFinderEvents/Details/5
        public ActionResult Register(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventFinderEvent eventFinderEvent = dbContext.EventFinderEvents.Find(id);
            if (eventFinderEvent == null)
            {
                return HttpNotFound();
            }
            return View(eventFinderEvent);
        }


        //GET: /ShoppingCart/AddToCart/5
        public ActionResult AddToCart(int id)
        {
            //id is EventID
            EventFinderEventShoppingCart cart = EventFinderEventShoppingCart.GetCart(this.HttpContext);
            cart.AddToCart(id);
            return RedirectToAction("OrderSummary");
        }

        //Ajax Call
        //POST: /ShoppingCart/RemoveFromCart/5
        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            //id == RecordId
            EventFinderEventShoppingCart cart = EventFinderEventShoppingCart.GetCart(this.HttpContext);
            string eventSelected = dbContext.EventFinderCarts.SingleOrDefault(c => c.RecordID == id).EventSelected.Title;
            int ItemCnt = cart.RemoveFromCart(id);

            EventFinderShoppingCartRemoveViewModel vm = new EventFinderShoppingCartRemoveViewModel()
            {
                ItemCount = ItemCnt,
                DeleteId = id,
                Message = $"{eventSelected} has been removed from your cart."
            };

            //creates JSON result
            return Json(vm);  // --> just updating portion of view
        }
    }
}

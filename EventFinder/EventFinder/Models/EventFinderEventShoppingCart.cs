using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventFinder.Models
{
    public class EventFinderEventShoppingCart
    {
        public string ShoppingCartId;
        private const string CartSessionKey = "CartId";
        EventFinderDB db = new EventFinderDB(); //datacontext

        public static EventFinderEventShoppingCart GetCart(HttpContextBase context)
        {
            EventFinderEventShoppingCart cart = new EventFinderEventShoppingCart();
            cart.ShoppingCartId = cart.GetCartId(context);
            return cart;
        }

        public string GetCartId(HttpContextBase context)
        {
            string cartId;
            if (context.Session[CartSessionKey] == null)
            {
                //create a cartID and add it to session variable
                cartId = Guid.NewGuid().ToString();
                context.Session[CartSessionKey] = cartId;

            }
            else
            {
                //retrieve cartID
                cartId = context.Session[CartSessionKey].ToString();
            }

            return cartId;
        }

        public List<EventFinderCart> GetCartItems()
        {
            return db.EventFinderCarts.Where(cart => cart.CartID == ShoppingCartId).ToList();
        }


        public void AddToCart(int id)
        {
            //cartItem exists already in db => update Count
            EventFinderCart cartItem = db.EventFinderCarts.SingleOrDefault(carts => carts.CartID == ShoppingCartId && carts.EventFinderEventID == id);
            if (cartItem == null)
            {
                EventFinderEvent eventFinderEvent = db.EventFinderEvents.SingleOrDefault(a => a.EventFinderEventID == id);
                cartItem = new EventFinderCart()
                {
                    CartID = ShoppingCartId,
                    EventFinderEventID = id,
                    EventSelected = eventFinderEvent,
                    Count = 1,
                    DateCreated = DateTime.Now
                };

                db.EventFinderCarts.Add(cartItem);
            }
            else
            {
                //cartItem does not exist in db => add item to db
                cartItem.Count++;
            }

            db.SaveChanges();
        }

        public int RemoveFromCart(int id)
        {
            EventFinderCart cartItem = db.EventFinderCarts.SingleOrDefault(carts => carts.RecordID == id);
            int count = 0;

            if (cartItem != null)
            {
                if (cartItem.Count > 1)
                {
                    cartItem.Count--;
                    count = cartItem.Count;
                }
                else
                {
                    db.EventFinderCarts.Remove(cartItem);
                }
                db.SaveChanges();
            }

            return count;
        }
    }
}
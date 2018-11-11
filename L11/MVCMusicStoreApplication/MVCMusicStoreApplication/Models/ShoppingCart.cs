using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMusicStoreApplication.Models
{
    public class ShoppingCart
    {
        public string ShoppingCartId;
        private const string CartSessionKey = "CartId";
        MVCMusicStoreDB db = new MVCMusicStoreDB(); //datacontext

        public static ShoppingCart GetCart(HttpContextBase context)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.ShoppingCartId = cart.GetCartId(context);
            return cart;
        }

        public string GetCartId(HttpContextBase context)
        {
            string cartId;
            if(context.Session[CartSessionKey] == null)
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

        public List<Cart> GetCartItems()
        {
            return db.Carts.Where(cart => cart.CartID == ShoppingCartId).ToList();
        }

        public decimal GetCartTotal()
        {
            decimal? total = (from cartItems in db.Carts
                             where cartItems.CartID == ShoppingCartId
                             select cartItems.AlbumSelected.Price * (int?) cartItems.Count).Sum();
            return total ?? decimal.Zero; 
        }

        public void AddToCart(int id)
        {
            //cartItem exists already in db => update Count
            Cart cartItem =  db.Carts.SingleOrDefault(carts => carts.CartID == ShoppingCartId && carts.AlbumId == id);
            if (cartItem == null)
            {
                Album album = db.Albums.SingleOrDefault(a => a.AlbumId == id);
                cartItem = new Cart()
                {
                    CartID = ShoppingCartId,
                    AlbumId = id,
                    AlbumSelected = album,
                    Count = 1,
                    DateCreated = DateTime.Now
                };

                db.Carts.Add(cartItem);
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
            Cart cartItem = db.Carts.SingleOrDefault(carts => carts.RecordID == id);
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
                    db.Carts.Remove(cartItem);
                }
                db.SaveChanges();
            }

            return count;
        }
    }
}
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
    }
}
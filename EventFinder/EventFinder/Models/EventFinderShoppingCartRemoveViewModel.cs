using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventFinder.Models.ViewModels
{
    public class EventFinderShoppingCartRemoveViewModel
    {
        public int DeleteId;
        public decimal CartTotal;
        public int ItemCount;
        public int CartCount;
        public string Message; //something like "Item removed"
    }
}
﻿using System.Web;
using System.Web.Mvc;

namespace WebApplication_Indiv
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new AuthorizeAttribute()); //all controllers use authorization
            filters.Add(new HandleErrorAttribute());
        }
    }
}

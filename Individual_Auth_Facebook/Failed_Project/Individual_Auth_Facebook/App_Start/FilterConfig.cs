using System.Web;
using System.Web.Mvc;

namespace Individual_Auth_Facebook
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

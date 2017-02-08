using System.Web;
using System.Web.Mvc;

namespace ZenithSociety_MichaelJung_AlbertChen
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

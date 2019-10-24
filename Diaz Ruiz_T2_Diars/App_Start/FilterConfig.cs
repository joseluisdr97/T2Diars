using System.Web;
using System.Web.Mvc;

namespace Diaz_Ruiz_T2_Diars
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

using System.Web;
using System.Web.Mvc;

namespace App_SpartansCustom_Rifas
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

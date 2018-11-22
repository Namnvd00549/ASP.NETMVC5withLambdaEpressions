using System.Web;
using System.Web.Mvc;

namespace ASP.NETMVC5withLambdaEpressions
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

using System.Web;
using System.Web.Mvc;

namespace CD161656_FM180247_Desafio01
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

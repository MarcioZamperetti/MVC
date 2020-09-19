using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using introdução;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using ProjetoASPNET_VazioComCRUD_EF6.Models;
using CRUD_EF.Models;
using introdução.Models;
using System.Data;

namespace introdução
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer<introduçãoContext>(null);
            Database.SetInitializer<introduçãoContext2>(null);
        }
    }
}

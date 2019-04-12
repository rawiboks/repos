using Inventory_System.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Inventory_System
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //Database.SetInitializer<Context>
            //    (new DropCreateDatabaseIfModelChanges<Context>());

            Database.SetInitializer<Context>(new DbInitializer());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;
using Vitter.Models;

namespace Vitter
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
#if DEBUG
            Database.SetInitializer(new VitterInitializer());
#endif

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}

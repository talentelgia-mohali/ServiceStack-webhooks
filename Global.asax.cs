using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebApplication1.Service;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {

        public class AppHost : AppHostBase
        {
            //Tell ServiceStack the name of your application and where to find your services
            public AppHost() : base("Hello Web Services", typeof(HelloSrevice).Assembly) { }

            public override void Configure(Funq.Container container)
            {
                //register any dependencies your services use, e.g:
                //container.Register<ICacheClient>(new MemoryCacheClient());
            }
        }

        protected void Application_Start()
        {
            new AppHost().Init();
            //AreaRegistration.RegisterAllAreas();
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}

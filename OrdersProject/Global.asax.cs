using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Castle.Windsor;
using Castle.Windsor.Installer;
using OrdersProject.Infrastructure;

namespace OrdersProject
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static IWindsorContainer _container;

        //tworzy kontener, instaluje wszystkie kontrolery z tego assembly i tworzy obiekt klasy WindsorControllerFactory i podmienia w ControllerBuilder defaultowy zestaw kontrolerów naszymi.

        private static void BootstrapContainer()
        {
            
        //WindsorControllerFactory tworzy obiekt poprzez pobranie go z kontenera
            _container = new WindsorContainer().Install(FromAssembly.This());

            //podmienia defaultowe kontrolery z naszym
            var controllerFactory = new WindsorControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            MvcApplication.BootstrapContainer();
        }

        protected void Application_End()
        {
            _container.Dispose();
        }


    }
}

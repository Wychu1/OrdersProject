using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using OrdersProject.DAL;
using OrdersProject.Repositories;

namespace OrdersProject.Infrastructure
{
    public class ServicesInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IOrderRepository>().ImplementedBy<OrderRepository>());

            container.Register(Component.For<OrderContext>());

        }
    }

}
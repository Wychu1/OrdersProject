using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using OrdersProject.DAL;
using OrdersProject.Repositories;

namespace OrdersProject.Infrastructure
{
    public class ServicesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IOrderRepository>().ImplementedBy<OrderRepository>());

            container.Register(Component.For<OrderContext>());

        }
    }

}
using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace OrdersProject.Infrastructure
{
    public class ControllersInstaller : IWindsorInstaller
    {
        
            public void Install(IWindsorContainer container, IConfigurationStore store)
            {
                //Rejestracja wszystkich klas które implementują interfejs IController
                container.Register(Classes.FromThisAssembly().BasedOn<IController>().LifestyleTransient());
            }
        
    }
}
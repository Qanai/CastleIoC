using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Credit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Castle.ConsoleApp
{
    public class ShoppingInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<Shopper>().LifeStyle.Transient);
            container.Register(Component.For<ICreditCard>().ImplementedBy<MasterCard>().LifeStyle.Transient);
        }
    }
}

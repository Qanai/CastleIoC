using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Credit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Install(new ShoppingInstaller());

            var shopper = container.Resolve<Shopper>();
            Console.WriteLine(shopper.Charge());
            Console.WriteLine(shopper.ChargesForCurrentCard);

            var shopper2 = container.Resolve<Shopper>();
            Console.WriteLine(shopper2.Charge());
            Console.WriteLine(shopper2.ChargesForCurrentCard);

            Console.Read();
        }
    }
}

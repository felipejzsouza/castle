using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;

namespace IoC
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();

            container.Register(Component.For<IComposition>()
                                .ImplementedBy<Composition>());
            container.Register(Component.For<IWriter>()
                                .ImplementedBy<ConsoleWriter>());

            var root = container.Resolve<IComposition>();

            root.LogMessage(string.Format("Log pelo processamento principal {0}", root.GetType().Name));

            Console.ReadLine();

        }
    }
}

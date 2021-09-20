using Autofac;
using ProcessA;
using ProcessB;
using ProcessContracts;
using System;

namespace DiAutofac
{
    internal class Program
    {
        private static IContainer conteiner;

        private static void Main(string[] args)
        {
            RegType();

            using (var scope = conteiner.BeginLifetimeScope())
            {
                var proc = scope.Resolve<IProcess>();
                proc.Execute();
            }

            Console.ReadLine();
        }

        private static void RegType()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ProcessClassA>().As<IProcess>();
            builder.RegisterType<ProcessClassB>().As<IProcess>();
            builder.RegisterType<ProcessClassA>().As<IProcess>();
            conteiner = builder.Build();
        }
    }
}
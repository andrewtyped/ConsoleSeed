using ConsoleSeed.Core.Logging;
using ConsoleSeed.DependencyResolution;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSeed
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;

            using (var container = IoC.Initialize(connectionString))
            using (var nestedContainer = container.GetNestedContainer())
            {
                RunApp(args, nestedContainer);
            }
        }

        static void RunApp(string[] args, IContainer container)
        {
            var logger = container.GetInstance<ILoggingService>();
            logger.Info("Entering application");

            Console.WriteLine("Hello, world!");
            Console.ReadKey();

            logger.Info("Exiting Application");
        }
    }
}

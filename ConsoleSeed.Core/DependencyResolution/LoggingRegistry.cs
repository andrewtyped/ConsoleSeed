using ConsoleSeed.Core.Logging;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSeed.Core.DependencyResolution
{
    public class LoggingRegistry : Registry
    {
        public LoggingRegistry()
        {
            For<ILoggingService>().Use(() => LoggingService.GetLoggingService());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Log4NetBasicSample
{
    class Program
    {       
        static void Main(string[] args)
        {
            // set up the logging componet - this uses the App.config settings
            log4net.Config.XmlConfigurator.Configure();

            // Create a logger for testing kttest is defined in App.config
            log4net.ILog _log;
            _log = log4net.LogManager.GetLogger("kttest");

            // Write to the logger
            _log.InfoFormat("Testing {0},{1},{2}", 1, 2, 3);
        }
    }
}

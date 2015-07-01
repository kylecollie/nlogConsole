using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Welcome to this NLog demo
             */
            Console.Out.WriteLine("Greetings, some loggings is about to take place.");
            Console.Out.WriteLine("");

            /*
             * This creates your logger. 
             * Notice that in the config file we defined that everything should go into the file.
             * (and if you set the console, it'll output to it as well).
             */
            Logger logger = LogManager.GetCurrentClassLogger();

            Console.Out.WriteLine("Let's assume you're going to work, and using the bus to get there:");
            Console.Out.WriteLine("------------------------------------------------------------------");
            logger.Trace("Trace: The chatter of people on the street");
            logger.Debug("Debug: Where are you going and why?");
            logger.Info("Info: What bus station you're at.");
            logger.Warn("Warn: You're playing on the phone and not looking up for your bus");
            logger.Error("Error: You get on the wrong bus.");
            logger.Fatal("Fatal: You are run over by the bus.");

            /*
             * Closing app
             */
            Console.Out.WriteLine("");
            Console.Out.WriteLine("Done logging.");
            Console.Out.WriteLine("Hit any key to exit");
            Console.ReadKey();
        }
    }
}

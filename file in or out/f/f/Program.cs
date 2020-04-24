using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f
{
  
            class Program
        {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
            {
                using (TextWriter writer = File.CreateText("e:\\ash.txt"))
                {
                    writer.WriteLine("Hello");
                    writer.WriteLine("ashwini");
                }
                log.Info("Data written successfully...");
            Console.ReadKey();
            }
        }
    }

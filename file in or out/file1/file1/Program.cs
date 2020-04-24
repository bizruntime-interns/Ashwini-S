using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file1
{
    class Input
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
                FileStream f = new FileStream("e:\\ash.txt", FileMode.OpenOrCreate);
                int i = 0;
                while ((i = f.ReadByte()) != -1)
                {
                    log.Info((char)i);
                Console.ReadKey();

                
                }
                f.Close();
            Console.ReadKey();
        }
    }
}

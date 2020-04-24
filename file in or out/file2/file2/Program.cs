using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file2
{
    class Create
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            FileStream f = new FileStream("e:\\ashw.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(f);

            s.WriteLine("Hello");
            s.Close();
            f.Close();
            log.Info("File created successfully...");
            Console.ReadLine();
        }
    }
}

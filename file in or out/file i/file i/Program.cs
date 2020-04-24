using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_i
{
    class Text
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
          
                try
                {
                    // Specifying file location  
                    string loc = "e:\\abc.txt";
                    // Creating FileInfo instance  
                    FileInfo file = new FileInfo(loc);
                    // Creating an empty file  
                    file.Create();
                    Console.WriteLine("File is created Successfuly");
                }
                catch (IOException e)
                {
                    Console.WriteLine("Something went wrong: " + e);
                }
            Console.ReadKey();
            }
        }
    }

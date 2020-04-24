using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskcreation
{
     class TaskCreate
    {
        private static readonly log4net.ILog log =
    log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void Main()
        {
            Task t = Task.Run(() =>   //Creates a Task and queues it to start running

            {
                for (int x = 0; x < 50; x++)
                {
                    log.Info("ash");  //printing value ash
                    Console.ReadKey();
                }
            });
            t.Wait();  //Waits for the task to complete
        }
    }
}
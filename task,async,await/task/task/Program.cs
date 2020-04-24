using System;
using System.Threading.Tasks;
namespace task
{
    class Taskprogram
    {
        static void Main()
        {
            Console.WriteLine("1)using run and wait method to print hello:");
            Task t = Task.Run(() =>  //creats a task and queues it to start running
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("hello");
                }
            });
            t.Wait();               //waits for the task to complete

            // without wait
            Console.WriteLine("2)without wait method:");
            Task t1 = Task.Run(() =>
             {
                 for (int i = 0; i < 20; i++)
                 {
                     Console.Write("ashwini");
                 }
             });
            t1.Wait();
            //using timespan for wait

            Console.WriteLine("3)using timespan for wait method:");
            Task t2 = Task.Run(() =>
             {
                 for (int i = 0; i < 100; i++)
                 {
                     Console.Write("ash");
                 }
             });
            TimeSpan ts = TimeSpan.FromMilliseconds(10);  //or displays time elapsed
            t2.Wait();





        }



    }
}


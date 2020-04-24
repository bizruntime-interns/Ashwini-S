using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Reactive.Linq;
namespace Observer
{
    class program
    {
        static void Main(string[] args)
        {
            var threadid = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"thread {threadid}");
            //creating a observer
            var observable = Observable.Range(5, 8);
         
            //ceating subscrive

            var subscription = observable.Subscribe(new observer());
            Console.ReadKey();
            subscription.Dispose();
        }

    
    }
}

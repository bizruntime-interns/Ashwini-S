using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Observer
{
    class observer : IObserver<int>
    {
        public void OnCompleted()
        {
            var threadid = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"thread completed {threadid}");
        }

        public void OnError(Exception error)
        {
            var threadid = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"thread {threadid}: {error:Message}");
        }

        public void OnNext(int value)
        {
            var threadid = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"thread {threadid}:{value}");
        }
    }
}

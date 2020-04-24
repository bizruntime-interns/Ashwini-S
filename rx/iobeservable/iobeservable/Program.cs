using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace iobeservable
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo();

            Console.WriteLine("press an key....");
            Console.ReadLine();


        }

        private static void Demo()
        {
            var subject = new Subject<int>();
            var sub = subject.Subscribe(Console.WriteLine);

            subject.OnNext(1);
            subject.OnNext(2);

            sub.Dispose();
            subject.OnNext(3); 
        }
    }
}

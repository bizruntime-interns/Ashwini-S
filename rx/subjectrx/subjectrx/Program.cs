using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace subjectrx
{
    class Program
    {
        static void Main(string[] args)
        {
            demo();
            Console.WriteLine("press an ke to exit...");
            Console.ReadKey();
        }

        static void demo()
        {
            var subject = new Subject<int>();

            var n = new[] { "hey ", "ashwini!" }.ToObservable();

            var s = n.Subscribe(subject);
        }
    }
}

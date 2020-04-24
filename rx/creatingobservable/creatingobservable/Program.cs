using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creatingobservable
{
    class Program
    {
        static void Main(string[] args)
        {
                
                var observable = Observable.Range(5, 8);
            IObserver<int> observer = Observer.Create<int>(
                Console.WriteLine, (error) => { Console.WriteLine(" {error:Message}"); },
                () => { Console.WriteLine(" completed "); });

                //ceating subscrive

                var subscription = observable.Subscribe();
                Console.ReadKey();
                subscription.Dispose();
            }
        }
    }


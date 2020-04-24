using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rx
{
    class Program
    {
        static void Main(string[] args)
        {
            var observableInstance = new observable();
            var observerInstance = new observer();
            var subscriptionHandle = observableInstance.Subscribe(observerInstance);
        }
    }
}

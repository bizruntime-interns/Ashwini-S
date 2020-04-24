using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rx
{
    class observer: IObserver<int>
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void OnCompleted()
            {
                log.Info("Observable is done sending all the data.");
            }

            public void OnError(Exception error)
            {
               log.Info($"Observable failed with error: {error.Message}");
            }

            public void OnNext(int value)
            {
                log.Info($"Observable emitted : {value}");
            Console.ReadKey();
            }
        }
    }


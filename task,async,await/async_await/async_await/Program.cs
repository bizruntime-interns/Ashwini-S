using System;
using System.Threading;
using System.Threading.Tasks;

namespace async_await
{
    class async
    {
        public static void Main(string[] args)
        {
           
           
        }

       

            public async void inmethod()
            {
                this.complete = false;
                Console.WriteLine("ashwini.. your work id getting done!!");

                await outmethod();
                Console.WriteLine("ashwini... your work is complete");
                this.complete = true;
            }

            public Task outmethod()   // void cannot be used in async to return 
            {
                return Task.Factory.StartNew(() =>
                    {
                        Console.WriteLine("working");
                        Thread.Sleep(2000); //temporarily suspends the current execution
                });

            }
        
        


        public bool complete { get; set; }
    }
}

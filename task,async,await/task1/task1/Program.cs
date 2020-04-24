using System;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Method3();
            Console.ReadKey();
        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" ash ");
                }
            });
            Task.WaitAny();
        }


        public static void Method2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" kirani");
            }
        }
        public static void Method3()
        {
            for (int i=0;i<10;i++)
            {
                Console.WriteLine("indira");
            }
        }
    }
}
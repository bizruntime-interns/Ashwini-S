using System;
using System.Threading.Tasks;
namespace tmethod
{
    class task
    {
        static void Main(string[] args)
        {
            Methodcall();
            Console.ReadKey();
        }

       
        public static async void Methodcall()
        {
            Task<int> t = task1();
            task2();
            int count = await t;
            task3(count);
        }
        public static async Task<int> task1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("ashwini");
                    count += 1;

                }
            });
            return count;

        }

        public static void task2()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("mansi");

            }
        }

        public static void task3(int count)
        {
            Console.WriteLine("count" + count);
        }


        }
    }


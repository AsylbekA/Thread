using System;
using System.Threading;

namespace Threaddddd
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(Count));
            thread.Start();
            
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Base potok");
                Console.WriteLine(i*i);
                Thread.Sleep(900);
            }
            Console.Read();
        }

        private static void Count()
        {
            for(int i = 1; i < 20; i++)
            {
                Console.WriteLine("Second potok");
                Console.WriteLine(i * i);
                Thread.Sleep(5000);
            }
        }
    }
}

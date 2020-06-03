using System;
using System.Threading;

namespace Threaddddd
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Thread thread = new Thread(new ThreadStart(Count));
            //    thread.Start();

            //    for (int i = 1; i < 10; i++)
            //    {
            //        Console.WriteLine("Base potok");
            //        Console.WriteLine(i*i);
            //        Thread.Sleep(900);
            //    }
            //    Console.Read();
            //}

            //private static void Count()
            //{
            //    for(int i = 1; i < 20; i++)
            //    {
            //        Console.WriteLine("Second potok");
            //        Console.WriteLine(i * i);
            //        Thread.Sleep(5000);
            //    }

            //Class cl = new Class();
            //cl.x = 5;
            //cl.y = 7;
            //int number = 5;

            Class c = new Class(6, 7);

            Thread thread = new Thread(new ThreadStart(c.Count));
            thread.Start();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Base ptotk");
            //    Console.WriteLine(i * i);
            //    Thread.Sleep(500);
            //}
        }
    }

    public class Class
    {
        public int x;
        public int y;

        public Class(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public  void Count()
        {
            for (int i = 0; i < 15; i++)
            {
                //Class c = (Class)obj;
                Console.WriteLine("Second potok");
                Console.WriteLine(i * i * x * y);
                Thread.Sleep(500);
            }
        }
    }


}

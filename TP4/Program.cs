using System;
using System.Threading;

namespace TP4
{
    class Program
    {
        static void RunEx1()
        {
            Console.WriteLine("####  EXERCISE 1  ####");

            Ex1.Simple();

            Ex1.Swap();

            Ex1.Semaphores();
        }

        static void RunEx2()
        {
            Console.WriteLine("####  EXERCISE 2  ####");

            Ex2.Run();
        }




        static void Main(string[] args)
        {
            RunEx1();

            RunEx2();
        }
    }
}

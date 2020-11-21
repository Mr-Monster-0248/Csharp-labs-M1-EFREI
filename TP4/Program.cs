using System;
using System.Threading;

namespace TP4
{
    class Program
    {
        static void Simple()
        {
            Console.WriteLine("1.");

            Ex1.ResetIToFive();

            Thread T1_1 = new Thread(new ThreadStart(Ex1.Increment));
            Thread T2_1 = new Thread(new ThreadStart(Ex1.Decrement));
            T1_1.Start();
            T2_1.Start();
            T1_1.Join();
            T2_1.Join();

            Console.WriteLine($"i = {Ex1.I}\n");
        }



        static void Swap()
        {
            Console.WriteLine("2.");

            Ex1.ResetIToFive();

            Thread T1_2 = new Thread(new ThreadStart(Ex1.IncrementSwap));
            Thread T2_2 = new Thread(new ThreadStart(Ex1.DecrementSwap));
            T1_2.Start();
            T2_2.Start();
            T1_2.Join();
            T2_2.Join();

            Console.WriteLine($"i = {Ex1.I}\n");
        }



        static void Semaphores()
        {
            Console.WriteLine("3.");

            Ex1.ResetIToFive();

            Thread T1_3 = new Thread(new ThreadStart(Ex1.IncrementSemaphores));
            Thread T2_3 = new Thread(new ThreadStart(Ex1.DecrementSemaphores));
            T1_3.Start();
            T2_3.Start();
            T1_3.Join();
            T2_3.Join();

            Console.WriteLine($"i = {Ex1.I}\n");
        }



        static void Main(string[] args)
        {
            Console.WriteLine("####  EXERCISE 1  ####");

            Simple();

            Swap();

            Semaphores();
        }
    }
}

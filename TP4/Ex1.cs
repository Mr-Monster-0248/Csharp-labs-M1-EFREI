using System;
using System.Threading;

namespace TP4
{
    class Ex1
    {
        private static int i = 5;
        public static int I => i;



        static Semaphore semaphore = new Semaphore(1, 1);



        public static void ResetIToFive()
        {
            i = 5;
        }





        private static void Increment()
        {
            i++;
        }

        private static void Decrement()
        {
            i--;
        }

        public static void Simple()
        {
            Console.WriteLine("1.");

            ResetIToFive();

            Thread T1 = new Thread(new ThreadStart(Increment));
            Thread T2 = new Thread(new ThreadStart(Decrement));
            T1.Start();
            T2.Start();
            T1.Join();
            T2.Join();

            Console.WriteLine($"i = {I}\n");
        }





        private static void IncrementSwap()
        {
            int reg = i;
            Thread.Sleep(2000);
            reg++;
            i = reg;
        }

        private static void DecrementSwap()
        {
            int reg = i;
            Thread.Sleep(2000);
            reg--;
            i = reg;
        }

        public static void Swap()
        {
            Console.WriteLine("2.");

            ResetIToFive();

            Thread T1 = new Thread(new ThreadStart(IncrementSwap));
            Thread T2 = new Thread(new ThreadStart(DecrementSwap));
            T1.Start();
            T2.Start();
            T1.Join();
            T2.Join();

            Console.WriteLine($"i = {I}\n");
        }





        private static void IncrementSemaphores()
        {
            semaphore.WaitOne();

            int reg = i;
            Thread.Sleep(2000);
            reg++;
            i = reg;

            semaphore.Release();
        }

        private static void DecrementSemaphores()
        {
            semaphore.WaitOne();

            int reg = i;
            Thread.Sleep(2000);
            reg--;
            i = reg;

            semaphore.Release();
        }

        public static void Semaphores()
        {
            Console.WriteLine("3.");

            Ex1.ResetIToFive();

            Thread T1 = new Thread(new ThreadStart(Ex1.IncrementSemaphores));
            Thread T2 = new Thread(new ThreadStart(Ex1.DecrementSemaphores));
            T1.Start();
            T2.Start();
            T1.Join();
            T2.Join();

            Console.WriteLine($"i = {I}\n");
        }
    }
}

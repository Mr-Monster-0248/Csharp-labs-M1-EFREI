using System;
using System.Collections.Generic;
using System.Threading;

namespace TP4
{
    class Ex2
    {
        public static List<int> computationList = new List<int>();

        static Semaphore semaphore = new Semaphore(1, 1);




        private static void Addition(int x, int y)
        {
            semaphore.WaitOne();
            computationList.Add(x + y);
            semaphore.Release();
        }

        private static void Multiplication(Thread thread)
        {
            computationList.Add(computationList[0] * computationList[1]);

            thread.Join();

            Console.WriteLine($"Final result : {computationList[2] * computationList[3]}");
        }




        public static void Run()
        {
            int A = 1,
                B = 2,
                C = 3,
                D = 4,
                E = 5,
                F = 6;


            Thread T1 = new Thread(() => Addition(A, B));
            Thread T2 = new Thread(() => Addition(C, -D));
            Thread T3 = new Thread(() => Addition(E, F));
            Thread T4 = new Thread(() => Multiplication(T3));


            T1.Start();
            T2.Start();
            T3.Start();


            T1.Join();
            T2.Join();


            T4.Start();
            T4.Join();
        }
    }
}
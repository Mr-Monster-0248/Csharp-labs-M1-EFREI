using System;
using System.Threading;

namespace TP4
{
    class Ex1
    {
        private static int i = 5;
        public static int I => i;



        private static object access_grant = new object();



        public static void ResetIToFive()
        {
            i = 5;
        }



        public static void Increment()
        {
            i++;
        }

        public static void IncrementSwap()
        {
            int reg = i;
            Thread.Sleep(2000);
            reg++;
            i = reg;
        }

        public static void IncrementSemaphores()
        {
            lock(access_grant)
            {
                int reg = i;
                Thread.Sleep(2000);
                reg++;
                i = reg;
            }
        }



        public static void Decrement()
        {
            i--;
        }

        public static void DecrementSwap()
        {
            int reg = i;
            Thread.Sleep(2000);
            reg--;
            i = reg;
        }

        public static void DecrementSemaphores()
        {
            lock (access_grant)
            {
                int reg = i;
                Thread.Sleep(2000);
                reg--;
                i = reg;
            }
        }
    }
}

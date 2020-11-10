using System;
using System.Collections.Generic;
using System.Threading;

namespace Efrei_labs
{
    class Exo4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exo 4");

            List<String> letterList = new List<String> { "A", "B", "C", "D", "E" };

            foreach (String letter in letterList)
            {
                Thread t = new Thread(new ParameterizedThreadStart(DisplayLetter.PrintLetter));
                t.Start(letter);
            }
        }
    }

    class DisplayLetter
    {
        public static void PrintLetter(object letter)
        {
            while (true)
            {
                Console.WriteLine(letter);
                Thread.Sleep(100);
            }
        }
    }
}

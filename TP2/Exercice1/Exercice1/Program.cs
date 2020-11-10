using System;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercice 1");

            PrimeSender sender = new PrimeSender();
            PrimeReceiver receiver = new PrimeReceiver();

            // Make the subscription from the sender to the receiver
            sender.PrimeFound += receiver.Action;

            sender.CalculatePrimes(10);
        }
    }
}

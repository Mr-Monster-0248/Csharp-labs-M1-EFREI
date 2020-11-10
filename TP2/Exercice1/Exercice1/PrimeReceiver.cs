using System;

namespace Exercice1
{
    class PrimeReceiver
    {
        public void Action(object sender, PrimeEventArgs args)
        {
            Console.WriteLine($"A prime number hass been found, it is: {args.Prime}");
        }
    }
}
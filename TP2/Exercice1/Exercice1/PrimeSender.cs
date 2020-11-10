using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice1
{
    class PrimeSender
    {
        public event EventHandler<PrimeEventArgs> PrimeFound;

        public void CalculatePrimes(long limit)
        {
            for (long i = 1; i < limit; i++)
            {
                bool isPrime = true;
                for (long j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                
                if (isPrime)
                {
                    PrimeEventArgs args = new PrimeEventArgs(i);
                    this.PrimeFound?.Invoke(this, args);
                }
            }
        }
    }
}

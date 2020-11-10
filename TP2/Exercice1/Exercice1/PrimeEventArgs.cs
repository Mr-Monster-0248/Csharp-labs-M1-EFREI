using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice1
{
    class PrimeEventArgs : EventArgs
    {
        private long _prime;

        public long Prime
        {
            get => _prime;
        }

        public PrimeEventArgs(long p) : base()
        {
            _prime = p;
        }
    }
}

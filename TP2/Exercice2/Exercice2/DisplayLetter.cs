using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Exercice2
{
    class DisplayLetter
    {
        private readonly string letter;

        public event EventHandler<string> Display;

        public DisplayLetter(string letter)
        {
            this.letter = letter;
        }

        public void PrintLetter()
        {
            while (true)
            {
                Display?.Invoke(this, letter);
                Thread.Sleep(100);
            }
        }
    }
}

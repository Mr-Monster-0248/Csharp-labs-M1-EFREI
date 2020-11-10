using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Efrei_labs
{
    class Exo2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exo 2");

            ClassA a = new ClassA();
            a.LongA = 10;
            Console.WriteLine(a.LongA);
            a.LongA = -10; // do not change as -10 is not strictly positive
            Console.WriteLine(a.LongA);

            ClassB b = new ClassB();
            b.Min = 1000;
            Console.WriteLine(b.Min); // is still 0 as it can't change to 1000

        }
    }

    class ClassA
    {
        private long _longA = 1;

        public long LongA
        {
            get => _longA;
            set
            {
                if (value > 0)
                {
                    _longA = value;
                }
            }
        }
    }

    class ClassB
    {
        private long _min, _max;

        public ClassB()
        {
            _min = 0;
            _max = 100;
        }

        public long Min
        {
            get => _min;
            set
            {
                if (value <= _max) _min = value;
            }
        }

        public long Max
        {
            get => _max;
            set
            {
                if (value >= _min) _max = value;
            }
        }

    }
}

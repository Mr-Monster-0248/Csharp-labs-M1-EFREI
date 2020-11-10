using System;

namespace Efrei_labs
{
    class Exo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            X obj1, obj2;
            obj1 = new X();
            obj2 = new X();
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }
    }
    class X
    {
        private static int _number;
        private readonly int _id;

        public X()
        {
            _number++;
            this._id = _number;
        }

        public override string ToString()
        {
            return $"Object from class X (number {this._id})";
        }
    }
}

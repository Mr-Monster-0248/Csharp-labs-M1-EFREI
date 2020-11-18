using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    [Serializable] class Mammal : Animal
    {
        public Mammal(string name) : base(name)
        {
        }

        public void Lactate()
        {
            Console.WriteLine("{0} is lactating.", this.name);
        }



        public override void Move()
        {
            Console.WriteLine("{0} is moving but it's a mammal.", this.name);
        }

        public override void Eat(string food)
        {
            Console.WriteLine("{0} is eating {1} but it's a mammal.", this.name, food);
        }
    }
}

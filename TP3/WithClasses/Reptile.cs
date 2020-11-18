using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    [Serializable] class Reptile : Animal
    {
        public Reptile(string name) : base(name)
        {
        }

        public void LayEggs()
        {
            Console.WriteLine("{0} is laying eggs.", this.name);
        }



        public override void Move()
        {
            Console.WriteLine("{0} is moving but it's a reptile.", this.name);
        }

        public override void Eat(string food)
        {
            Console.WriteLine("{0} is eating {1} but it's a reptile.", this.name, food);
        }
    }
}

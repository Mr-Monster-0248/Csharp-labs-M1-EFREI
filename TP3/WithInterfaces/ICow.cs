using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    [Serializable] class ICow : IMammal
    {
        private string _name;
        public string name => _name;


        public ICow(string name)
        {
            this._name = name;
        }


        public void Move()
        {
            Console.WriteLine("{0} is moving on 4 legs.", this.name);
        }

        public void Eat(string food)
        {
            Console.WriteLine("{0} is eating {1}. It's a herbivore.", this.name, food);
        }

        public void Lactate()
        {
            Console.WriteLine("{0} is lactating, because it's a mammal.", this.name);
        }
    }
}

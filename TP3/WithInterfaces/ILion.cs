using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    [Serializable] class ILion : IMammal
    {
        private string _name;
        public string name => _name;


        public ILion(string name)
        {
            this._name = name;
        }


        public void Move()
        {
            Console.WriteLine("{0} is moving on 4 legs.", this.name);
        }

        public void Eat(string food)
        {
            Console.WriteLine("{0} is eating {1}. It loves meat.", this.name, food);
        }

        public void Lactate()
        {
            Console.WriteLine("{0} is lactating, because it's a mammal.", this.name);
        }
    }
}

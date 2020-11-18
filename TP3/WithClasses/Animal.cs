using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    [Serializable] class Animal
    {
        private string _name;
        public string name => _name;


        public Animal(string name)
        {
            this._name = name;
        }

        public virtual void Move()
        {
            Console.WriteLine("{0} is moving.", this.name);
        }

        public virtual void Eat(string food)
        {
            Console.WriteLine("{0} is eating {1}.", this.name, food);
        }
    }
}

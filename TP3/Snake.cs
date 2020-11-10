using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    [Serializable] class Snake : IReptile
    {
        private string _name;
        public string name => _name;


        public Snake(string name)
        {
            this._name = name;
        }


        public void Move()
        {
            Console.WriteLine("{0} is crawling on the ground.", this.name);
        }

        public void Eat(string food)
        {
            Console.WriteLine("{0} is eating {1}. Digestion can take up to 18 months!", this.name, food);
        }

        public void LayEggs()
        {
            Console.WriteLine("{0} is laying eggs, because it's a reptile.", this.name);
        }
    }
}

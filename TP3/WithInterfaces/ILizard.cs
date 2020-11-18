using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    [Serializable] class ILizard : IReptile
    {
        private string _name;
        public string name => _name;


        public ILizard(string name)
        {
            this._name = name;
        }


        public void Move()
        {
            Console.WriteLine("{0} is crawling on its 4 little legs.", this.name);
        }

        public void Eat(string food)
        {
            Console.WriteLine("{0} is eating {1}.", this.name, food);
        }

        public void LayEggs()
        {
            Console.WriteLine("{0} is laying eggs, because it's a reptile.", this.name);
        }
    }
}

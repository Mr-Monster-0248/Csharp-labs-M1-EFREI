using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    [Serializable] class IPlatypus : IMammal, IReptile
    {
        private string _name;
        public string name => _name;


        public IPlatypus(string name)
        {
            this._name = name;
        }


        public void Move()
        {
            Console.WriteLine("{0} is swimming when it's not walking on 4 legs.", this.name);
        }

        public void Eat(string food)
        {
            Console.WriteLine("{0} is eating {1}. It can break harder foods with its beak-like mouth.", this.name, food);
        }

        public void LayEggs()
        {
            Console.WriteLine("{0} is laying eggs, because platypuses are part reptile.", this.name);
        }

        public void Lactate()
        {
            Console.WriteLine("{0} is lactating, because platypuses are part mammal.", this.name);
        }
    }
}

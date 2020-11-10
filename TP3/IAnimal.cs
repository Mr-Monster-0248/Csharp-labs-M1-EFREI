using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    interface IAnimal
    {
        void Move();

        void Eat(string food);

        string name { get; }
    }
}

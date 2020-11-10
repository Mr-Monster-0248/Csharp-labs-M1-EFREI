
using System;
using System.Collections.Generic;
using System.Text;

namespace Efrei_labs
{
    class Exo3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exo 3");
            new Trumpet().Play();
        }
    }

    abstract class Instrument
    {
        public Instrument() => Console.WriteLine("Instrument is called");

        abstract public void Play();
    }

    abstract class Brass : Instrument
    {
        public Brass() => Console.WriteLine("Brass is called"); 

        virtual public void Blow()
        {
            Console.WriteLine("Tuuut");
        }
    }

    class Trumpet : Brass
    {
        public Trumpet() => Console.WriteLine("Trumpet is called");

        public override void Play()
        {
            Blow();
        }
    }
}

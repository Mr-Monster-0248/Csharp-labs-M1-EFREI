﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace TP3
{
    [Serializable] class Zoo
    {
        private List<IAnimal> _animals;
        private List<IAnimal> Animals => _animals;


        [NonSerialized] private string _filename = "./zoo.bin";




        public Zoo()
        {
            this._animals = new List<IAnimal>();
        }




        public void AddAnimal(IAnimal animal)
        {
            this.Animals.Add(animal);
        }




        public void MakeAllWalk()
        {
            foreach(IAnimal animal in this.Animals)
            {
                animal.Move();
            }
        }

        public void MakeAllEat()
        {
            foreach (IAnimal animal in this.Animals)
            {
                animal.Eat("food");
            }
        }




        public void SerializeZoo()
        {
            FileStream stream = new FileStream(this._filename, FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, this);

            stream.Close();
        }

        public Zoo DeserializeZoo()
        {
            FileStream stream = new FileStream(this._filename, FileMode.Open);

            BinaryFormatter bf = new BinaryFormatter();

            Zoo ds = (Zoo)bf.Deserialize(stream);

            stream.Close();

            return ds;
        }
    }
}

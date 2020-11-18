using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace TP3
{
    [Serializable] class CZoo
    {
        private List<Animal> _animals;
        private List<Animal> Animals => _animals;


        [NonSerialized] private string _filename = "./zoo.bin";




        public CZoo()
        {
            this._animals = new List<Animal>();
        }




        public void AddAnimal(Animal animal)
        {
            this.Animals.Add(animal);
        }




        public void MakeAllWalk()
        {
            foreach(Animal animal in this.Animals)
            {
                animal.Move();
            }
        }

        public void MakeAllEat()
        {
            foreach (Animal animal in this.Animals)
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

        public CZoo DeserializeZoo()
        {
            FileStream stream = new FileStream(this._filename, FileMode.Open);

            BinaryFormatter bf = new BinaryFormatter();

            CZoo ds = (CZoo)bf.Deserialize(stream);

            stream.Close();

            return ds;
        }
    }
}

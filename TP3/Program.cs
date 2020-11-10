using System;

namespace TP3
{
    class Program
    {
        public static void LineBreak()
        {
            Console.WriteLine();
        }


        public static void Main()
        {
            Cow cow = new Cow("Marguerite");
            Lion lion = new Lion("Mufasa");

            Snake snake = new Snake("Kaa");
            Lizard lizard = new Lizard("Rango");

            Platypus platypus = new Platypus("Perry");


            cow.Eat("grass");
            cow.Move();
            cow.Lactate();

            LineBreak();

            lion.Eat("meat");
            lion.Move();
            lion.Lactate();

            LineBreak();

            snake.Eat("small animals");
            snake.Move();
            snake.LayEggs();

            LineBreak();

            lizard.Eat("insects");
            lizard.Move();
            lizard.LayEggs();

            LineBreak();

            platypus.Eat("insects");
            platypus.Move();
            platypus.Lactate();
            platypus.LayEggs();

            LineBreak();

            Console.WriteLine("Creating zoo...");
            Zoo zoo = new Zoo();
            zoo.AddAnimal(cow);
            zoo.AddAnimal(lion);
            zoo.AddAnimal(snake);
            zoo.AddAnimal(lizard);
            zoo.AddAnimal(platypus);

            LineBreak();

            zoo.MakeAllEat();

            LineBreak();

            zoo.MakeAllWalk();

            Console.WriteLine("Serializing the zoo...");
            zoo.SerializeZoo();

            Console.WriteLine("Creating new zoo from serialized zoo...");
            Zoo newZoo = zoo.DeserializeZoo();

            LineBreak();

            Console.WriteLine("Testing new zoo :");
            newZoo.MakeAllEat();
        }
    }
}

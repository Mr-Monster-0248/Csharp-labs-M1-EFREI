using System;

namespace TP3
{
    class Program
    {
        public static void LineBreak()
        {
            Console.WriteLine();
        }





        public static void TestWithInterfaces()
        {
            Console.WriteLine("##### TESTING WITH INTERFACES #####\n");


            ICow cow = new ICow("Marguerite");
            ILion lion = new ILion("Mufasa");

            ISnake snake = new ISnake("Kaa");
            ILizard lizard = new ILizard("Rango");

            IPlatypus platypus = new IPlatypus("Perry");


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

            Console.WriteLine("# CREATING ZOO ...");
            IZoo zoo = new IZoo();
            zoo.AddAnimal(cow);
            zoo.AddAnimal(lion);
            zoo.AddAnimal(snake);
            zoo.AddAnimal(lizard);
            zoo.AddAnimal(platypus);

            LineBreak();

            zoo.MakeAllEat();

            LineBreak();

            zoo.MakeAllWalk();

            Console.WriteLine("# SERIALIZING ZOO ...");
            zoo.SerializeZoo();

            Console.WriteLine("# CREATING NEW ZOO FROM SERIALIZED ZOO ...");
            IZoo newZoo = zoo.DeserializeZoo();

            LineBreak();

            Console.WriteLine("# TESTING NEW ZOO :");
            newZoo.MakeAllEat();


            Console.WriteLine("\n\n");
        }



        public static void TestWithClasses()
        {
            Console.WriteLine("##### TESTING WITH CLASSES #####\n");


            CCow cow = new CCow("Marguerite");
            CLion lion = new CLion("Mufasa");

            CSnake snake = new CSnake("Kaa");
            CLizard lizard = new CLizard("Rango");

            CPlatypus platypus = new CPlatypus("Perry");


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

            Console.WriteLine("# CREATING ZOO ...");
            CZoo zoo = new CZoo();
            zoo.AddAnimal(cow);
            zoo.AddAnimal(lion);
            zoo.AddAnimal(snake);
            zoo.AddAnimal(lizard);
            zoo.AddAnimal(platypus);

            LineBreak();

            zoo.MakeAllEat();

            LineBreak();

            zoo.MakeAllWalk();

            Console.WriteLine("# SERIALIZING ...");
            zoo.SerializeZoo();

            Console.WriteLine("# CREATING NEW ZOO FROM SERIALIZED ZOO ...");
            CZoo newZoo = zoo.DeserializeZoo();

            LineBreak();

            Console.WriteLine("# TESTING NEW ZOO :");
            newZoo.MakeAllEat();

            Console.WriteLine("\n\n");
        }





        public static void Main()
        {
            TestWithInterfaces();
            
            TestWithClasses();
        }
    }
}

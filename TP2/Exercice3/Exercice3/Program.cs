using System;
using System.Threading;

namespace Exercice3
{
    class Program
    {
        static readonly SystemResource printer = new SystemResource(ResourceType.Printer);
        static readonly SystemResource ram = new SystemResource(ResourceType.Ram);
        static readonly SystemResource disk = new SystemResource(ResourceType.Disk);

        /**
         * <summary>
         * Exemple of a thread loading a file from disk,
         * then into the RAM and print it
         * </summary>
         */
        public static void ThA()
        {
            AskResource PrintJob = new AskResource();
            PrintJob.AddResource(disk, 2);
            PrintJob.AddResource(ram, 1);
            PrintJob.AddResource(printer, 8);
            PrintJob.Run();
        }

        /**
         * <summary>
         * Exemple of a thread loading two file from disk
         * and print it
         * </summary>
         */
        public static void ThB()
        {
            AskResource TestPrinter = new AskResource();
            TestPrinter.AddResource(ram, 1);
            TestPrinter.AddResource(ram, 1);
            TestPrinter.AddResource(printer, 10);
            TestPrinter.Run();
        }

        /**
         * <summary>
         * Exemple of a thread printing a big file from disk
         * </summary>
         */
        public static void ThC()
        {
            AskResource BigPrintJob = new AskResource();
            BigPrintJob.AddResource(disk, 15);
            BigPrintJob.AddResource(ram, 5);
            BigPrintJob.AddResource(ram, 1);
            BigPrintJob.AddResource(printer, 2);
            BigPrintJob.AddResource(ram, 1);
            BigPrintJob.AddResource(printer, 2);
            BigPrintJob.AddResource(ram, 1);
            BigPrintJob.AddResource(printer, 2);
            BigPrintJob.AddResource(ram, 1);
            BigPrintJob.AddResource(printer, 2);
            BigPrintJob.AddResource(ram, 1);
            BigPrintJob.AddResource(printer, 2);
            BigPrintJob.Run();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Exercice 3");

            Thread TA = new Thread(new ThreadStart(ThA));
            Thread TB = new Thread(new ThreadStart(ThB));
            Thread TC = new Thread(new ThreadStart(ThC));
            TA.Start();
            TB.Start();
            TC.Start();
        }
    }
}

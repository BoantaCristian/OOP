using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        private static bool exit = false;

        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            Thread.Sleep(3000);
            stopWatch.Stop();

            Console.WriteLine("Stopwatch:");
            Console.WriteLine("1) Start/Reset");
            Console.WriteLine("2) Stop");
            Console.WriteLine("3) Exit");

            while (!exit)
            {
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                    {
                        stopWatch.Start();
                        break;
                    }
                    case "2":
                    {
                        stopWatch.Stop();
                        break;
                    }
                    case "3":
                    {
                        exit = true;
                        break;
                    }
                    default: break;
                }
            }
        }
    }
}

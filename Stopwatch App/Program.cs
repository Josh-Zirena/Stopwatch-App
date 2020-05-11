using System;
using System.Diagnostics;
using System.Threading;

namespace Stopwatch_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            Console.WriteLine("Stopwatch App");
            Console.WriteLine("=================");
            Console.WriteLine("Instructions..");
            Console.WriteLine("Type 'start' to start the stopwatch.\nType 'stop' to stop the stopwatch.\nType 'quit' to quit the stopwatch.\n");
            

            while (true)
            {
                var input = Console.ReadLine();
                Console.WriteLine("");
                if (input.ToLower() == "start")
                    stopwatch.Start();

                else if (input.ToLower() == "stop")
                    stopwatch.Stop();
                else if (input.ToLower() == "quit")
                    break;
                else
                {
                    Console.WriteLine("Please enter 'start', 'stop', or 'quit' for functionality.\n");
                }    
            }
        }
    }
}

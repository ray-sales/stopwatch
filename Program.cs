using System;
using System.Threading;

namespace stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("s - Seconds");
            Console.WriteLine("m - Minutes");
            Console.WriteLine("x - Exit");
            Console.WriteLine("How much time do You want to count? EX.: 10s or 1m");

            string data = Console.ReadLine().ToLower();

            if (data == "x")
            {
                System.Environment.Exit(0);
            }

            char type = char.Parse(data.Substring((data.Length - 1), 1));
            int time = int.Parse(data.Substring(0, (data.Length - 1)));

            int multiplier = type == 'm' ? 60 : 1;



            PreStart(time * multiplier);


        }

        static void PreStart(int time)
        {
            showPhrase("Ready...", 1000);
            showPhrase("Set...", 1000);
            showPhrase("Go!!!", 2500);
            Start(time);
        }

        static void showPhrase(string text, int timeSleep)
        {
            Console.Clear();
            Console.WriteLine(text);
            Thread.Sleep(timeSleep);
        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            showPhrase("Finished timer", 2500);
            Menu();
        }
    }
}

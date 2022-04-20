using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input;
            var Timer = new StopWatch();
            Console.WriteLine("Enter S to start the Timer and Q to Stop");
            Input = Console.ReadLine();

            while (!string.IsNullOrEmpty(Input))
            {
                if (string.Equals("s", Input) || string.Equals("S", Input))
                {
                    Timer.Start();
                    Console.WriteLine("Enter Q to Stop");
                }
                else if (string.Equals("Q", Input, StringComparison.CurrentCultureIgnoreCase))
                {
                    Timer.Stop();
                    Console.WriteLine("Enter S to start the timer");
                }

                Input = Console.ReadLine();
            }
        }
    }
}

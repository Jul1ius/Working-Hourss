using System;

namespace _07.Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            if (dayOfWeek == "Sunday")
            {
                Console.WriteLine("closed");
            }
            else
            {
                if (time < 10 || time > 18)
                {
                    Console.WriteLine("closed");
                }
                else
                {
                    Console.WriteLine("open");
                }
            }
        }
    }
}
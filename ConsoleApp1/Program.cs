using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            var userInput = int.Parse(Console.ReadLine());

            if (userInput > 13)
            {
                Console.WriteLine("Too High!");
            }
            else if (userInput < 13)
            {
                Console.WriteLine("Too Low!");
            }
            else if (userInput == 13)
            {
                Console.WriteLine("Ding! Ding! Ding! We have a winner!");
            }
                    
        }
    }
}

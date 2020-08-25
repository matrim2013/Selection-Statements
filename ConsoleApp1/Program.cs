using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            int userInput;

            Console.WriteLine("Guess my age");

            do
            {
                userInput = int.Parse(Console.ReadLine());

                if (userInput > favNumber)
                {
                    Console.WriteLine("Too High!");
                }
                else if (userInput < favNumber)
                {
                    Console.WriteLine("Too Low!");
                }
                else if (userInput == favNumber)
                {
                    Console.WriteLine("Ding! Ding! Ding! We have a winner!");
                }
            } while (userInput != favNumber);

            
                    
        }
    }
}

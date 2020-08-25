using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            string favSub = Console.ReadLine();

            switch (favSub.ToLower())
            {
                case "math":
                    Console.WriteLine("Numbers are everything");
                    break;
                case "science":
                    Console.WriteLine("A curious mind I see");
                    break;
                case "english":
                    Console.WriteLine("We have a poet among us");
                    break;

                default:
                    Console.WriteLine("Beat to the sound of your own drum eh");
                    break;
                                                      

            }
                   
        }
    }
}

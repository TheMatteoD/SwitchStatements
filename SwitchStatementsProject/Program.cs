using System;

namespace SwitchStatementsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "English":
                    Console.WriteLine("English: I can speak Egnlish too!");
                    break;
                case "Math":
                    Console.WriteLine("Math: 2 + 2 = 4 right?");
                    break;
                case "Science":
                    Console.WriteLine("Science: I watch a lot of Sci-Fi!");
                    break;
                case "History":
                    Console.WriteLine("History: You're stuck in the past.");
                    break;
                case "Geography":
                    Console.WriteLine("Geography: I have a gps.");
                    break;
                default:
                    Console.WriteLine("I don't know what that is. Can you explain in detail?");
                    Console.ReadLine();
                    Console.WriteLine("k");
                    break;
            }
        }
    }
}

using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool guessed = false;
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            int userInput;

            while (guessed == false)
            {
                Console.WriteLine("Guess a number!");

                userInput = int.Parse(Console.ReadLine());

                if (userInput == favNumber)
                {
                    Console.WriteLine("Nailed it!");
                    guessed = true;
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine("Too low!");
                }
            }

            Console.WriteLine("What's your favorite school subject?");
            string favSubject = Console.ReadLine();

            switch (favSubject)
            {
                case "Math":
                    {
                        Console.WriteLine("Math is important!");
                        break;
                    }
                case "Science":
                    {
                        Console.WriteLine("Science is cool!");
                        break;
                    }
                case "Computer Science":
                    {
                        Console.WriteLine("Nerd!");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Never heard of it, but it sounds cool!");
                        break;
                    }
            }
        }
    }
}
// See https://aka.ms/new-console-template for more information


using System;

namespace RPS
{
    public class Play
    {
        static void Main(string[] args)
        {
            bool playing = true;
            int userPoints = 0;
            int computerPoints = 0;
            while (playing)
            {

                Console.WriteLine("Welcome to my Rock, Paper, Scissors game. Enter a number below for your choice and press enter:");
                Console.WriteLine("a.Rock b.Paper c.Scissor");
                char userChoice = Console.ReadKey().KeyChar;
                Random randomChoice = new Random();
                int computerChoice = randomChoice.Next(1, 4);
                Console.WriteLine("");

                switch (computerChoice)
                {
                    case 1:
                        if (userChoice == 'a')
                        {
                            Console.WriteLine("User Chose Rock");
                            Console.WriteLine("Computer Chose Rock");
                            Console.WriteLine("It is a Tie");
                        }
                        else if (userChoice == 'b')
                        {
                            Console.WriteLine("User Chose Paper");
                            Console.WriteLine("Computer Chose Rock");
                            Console.WriteLine("You Won");
                            userPoints++;
                        }
                        else if (userChoice == 'c')
                        {
                            Console.WriteLine("User Chose Scissors");
                            Console.WriteLine("Computer Chose Rock");
                            Console.WriteLine("You Lost");
                            computerPoints++;
                        }
                        break;
                    case 2:
                        if (userChoice == 'a')
                        {
                            Console.WriteLine("User Chose Rock");
                            Console.WriteLine("Computer Chose Paper");
                            Console.WriteLine("You Lost");
                            computerPoints++;
                        }
                        else if (userChoice == 'b')
                        {
                            Console.WriteLine("User Chose Paper");
                            Console.WriteLine("Computer Chose Paper");
                            Console.WriteLine("It is a Tie");
                        }
                        else if (userChoice == 'c')
                        {
                            Console.WriteLine("User Chose Scissors");
                            Console.WriteLine("Computer Chose Paper");
                            Console.WriteLine("You won");
                            userPoints++;
                        }
                        break;
                    case 3:
                        if (userChoice == 'a')
                        {
                            Console.WriteLine("User Chose Rock");
                            Console.WriteLine("Computer Chose Scissors");
                            Console.WriteLine("You Won");
                            userPoints++;
                        }
                        else if (userChoice == 'b')
                        {
                            Console.WriteLine("User Chose Paper");
                            Console.WriteLine("Computer Chose Scissors");
                            Console.WriteLine("You Lost");
                            computerPoints++;
                        }
                        else if (userChoice == 'c')
                        {
                            Console.WriteLine("User Chose Scissors");
                            Console.WriteLine("Computer Chose Scissors");
                            Console.WriteLine("It is a Tie");
                        }
                        break;
                }
                Console.WriteLine("Your Points:", userPoints);
                Console.WriteLine("Computer Points:", computerPoints);
                Console.WriteLine("Do You Wish To Play Again?");
                Console.WriteLine("Enter Y or N");




            }
        }

    }
}



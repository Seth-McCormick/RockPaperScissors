using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPS.models
{
    public class Game
    {

    }
}




Console.WriteLine("Hello, World!");
Console.Clear();

bool playing = true;
int userPoints = 0;
int computerPoints = 0;

while (playing)
{
    Console.WriteLine("Hello and Welcome to my Rock, Paper, Scissors game. Please enter a number below for your choice and press enter:");
    Console.WriteLine("1.Rock");
    Console.WriteLine("2.Paper");
    Console.WriteLine("3.Scissors");

    string userChoice = Console.ReadLine();
    Random randomChoice = new Random();
    int computerChoice = randomChoice.Next(1, 4);
    string keepPlaying = Console.ReadKey();

    switch (computerChoice)
    {
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;

    }
    if (userChoice == 1)
    {

    }

    if (keepPlaying.ToLower == 'n')
    {
        playing = false;

    }
}
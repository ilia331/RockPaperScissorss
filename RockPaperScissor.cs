using System.ComponentModel.Design;

const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";

Console.WriteLine("Chose [r]ock, [p]aper, [s]cissors");
Console.BackgroundColor = ConsoleColor.Yellow;
string playerMove = Console.ReadLine();

if (playerMove == "r" || playerMove == "rock")
{
    playerMove = Rock;
}
else if (playerMove == "p" || playerMove == "paper")
{
    playerMove = Paper;
}
else if (playerMove == "s" || playerMove == "scissors")
{
    playerMove = Scissors;
}

else
{
    Console.WriteLine("Invalid Input. Try again");
    Console.BackgroundColor = ConsoleColor.Red;
}

Random random = new Random();
int computerRandomNumber = random.Next(1, 4);
string computerMove = "";

switch (computerRandomNumber)
{
    case 1:
        computerMove = Rock;
        break;
    case 2:
        computerMove = Paper;
        break;
    case 3:
        computerMove = Scissors;
        break;
}

Console.WriteLine($"The computer chose {computerMove}.");
Console.BackgroundColor = ConsoleColor.Gray;

if ((playerMove == Rock && computerMove == Scissors) ||
    (playerMove == Paper && computerMove == Rock) ||
    (playerMove == Scissors && computerMove == Paper))
{
    Console.WriteLine("You Win.");
    Console.BackgroundColor = ConsoleColor.Green;
}


else if ((playerMove == Rock && computerMove == Paper) ||
    (playerMove == Paper && computerMove == Scissors) ||
    (playerMove == Scissors && computerMove == Rock))
{
    Console.WriteLine("You lose");
    Console.BackgroundColor = ConsoleColor.Red;
}
else
{
    Console.WriteLine("This game was a draw");
    Console.BackgroundColor = ConsoleColor.Green;
}

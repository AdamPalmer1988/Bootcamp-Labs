using System.ComponentModel.Design;

int diceSides = 6;

Console.WriteLine("Welcome to the Grand Circus Casino!");

Console.WriteLine("How many sides should each die have?");
string newDiceSides = Console.ReadLine();
diceSides = int.Parse(newDiceSides);

int rollCounter = 1;

string keepPlaying = "y";

Random rnd1 = new Random();
int dice1 = rnd1.Next(1, (diceSides + 1));
Random rnd2 = new Random();
int dice2 = rnd2.Next(1, (diceSides + 1));

int diceTotal = (dice1 + dice2);

Console.WriteLine($"Roll {rollCounter}" );
Console.WriteLine($"Dice 1: {dice1} and Dice 2: {dice2}");
Console.WriteLine($"Dice Total: {diceTotal}");

rollCounter++;

while ( keepPlaying == "y")
{
    Console.WriteLine("Would you like to play again? (Y/N)?");
    keepPlaying = Console.ReadLine();

    if (keepPlaying == "n")
    {
        Console.WriteLine("Thank you for playing!");
    }
    else
    {
        dice1 = rnd1.Next(1, (diceSides + 1));
        dice2 = rnd2.Next(1, (diceSides + 1));
        diceTotal = dice1 + dice2;

        Console.WriteLine($"Roll {rollCounter}");
        Console.WriteLine($"Dice 1: {dice1} and Dice 2: {dice2}");
        Console.WriteLine($"Dice Total: {diceTotal}");

        string diceResult = $"{dice1} and {dice2}";

        switch (diceResult)
        {
            case "1 and 1":
                Console.WriteLine("Snake Eyes!");
                break;
            case "1 and 2":
            case "2 and 1":
                {
                    Console.WriteLine("Ace Deuce");
                }
                break;
            case "6 and 6":
                {
                    Console.WriteLine("Box Cars");
                }
                break;
        }

        if (diceTotal == 7 || diceTotal == 11)
        {
            Console.WriteLine("You Win!");
        }

        else if (diceTotal == 2 || diceTotal == 3 || diceTotal == 12)
        {
            Console.WriteLine("CRAPS!");
        }
        
        rollCounter++;
    }
}
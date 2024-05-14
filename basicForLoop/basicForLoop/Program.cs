int runningTotal = 0;
string playAgain = "Yes";
string responseString;
int response;

while (playAgain == "Yes")
{
    Console.WriteLine("Enter a number:");
    responseString = Console.ReadLine();
    response = int.Parse(responseString);

    for (int i = 0; i <= response; i++)
    {
        runningTotal += i;
    }

    Console.WriteLine($"Your total is {runningTotal}!");
    Console.WriteLine("Would you like to play again? Yes or No");
    playAgain = Console.ReadLine();
    runningTotal = 0;

}
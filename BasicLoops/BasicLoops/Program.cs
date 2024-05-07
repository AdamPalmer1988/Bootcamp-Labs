using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;


Console.WriteLine("Description #1");
//Use a do-while loop to output "Hello, World!" in a loop. Each time you output 
//"Hello, World!" ask the user whether they would like to continue.

string answer = "y";

do
{
    Console.WriteLine("Hello World!");
    Console.WriteLine("Would you like to continue");
    answer = Console.ReadLine();
}
while (answer.ToLower() == "y");

Console.WriteLine("Goodbye!");


Console.WriteLine("Description #2");

//Prompt the user for a number. Use a for loop to output all the numbers from that number to 0.
//After that loop finishes, use another loop to output all the numbers from 0 to that number.

string playAgain = "y";

while (playAgain.ToLower() == "y")
{

    int number = 0;
    int counter = 0;
    string stringNumber;

    Console.WriteLine("Enter a number:");
    stringNumber = Console.ReadLine();
    number = int.Parse(stringNumber);

    while (counter <= number)
    {
        Console.Write(counter + " ");
        counter++;
    }

    counter = number;
    Console.WriteLine();

    while (counter > -1)
    {
        Console.Write(counter + " ");
        counter--;
    }

    Console.WriteLine();
    Console.WriteLine("Would you like to play again? Y or N?");
    playAgain = Console.ReadLine();
}

Console.WriteLine("Goodbye!");

Console.WriteLine("Description #3");

//A door has a keypad entry. The combination to get in is 13579. Write a while
//loop (not a do while loop) that asks the user to enter a key code. The loop will
//repeat as long as the user enters the wrong code. After the user enters the
//correct code, the program will print out a welcome message.

string password = "13579";
Console.WriteLine("Please enter 5 digit password and press enter:");
string guess = Console.ReadLine();

while ( guess != password )
{
    Console.WriteLine("Incorrect: Please try again!");
    Console.WriteLine("Please enter 5 digit password and press enter:");
    guess = Console.ReadLine();
}

Console.WriteLine("Password is Correct!");

Console.WriteLine("Description #4");

//Continue the previous exercise, but now add a limited number of tries, say 5.
//After 5 unsuccessful attempts, the loop ends, but instead of printing a welcome message,
//it prints a message warning that there were too many incorrect attempts.
//(But if the user entered the correct number, it will still print the welcome message as before.)

Console.WriteLine("Please enter 5 digit password and press enter:");
guess = ""; 
password = "13579";
int tries = 1;
int triesLimit = 5;

while ((tries <= triesLimit) && (guess != password))
{
    guess = Console.ReadLine();
    {
        Console.WriteLine("Incorrect: Please try again!");
        Console.WriteLine("Please enter 5 digit password and press enter:");
        guess = Console.ReadLine();
        tries++;

        if (guess == password)
        {
            Console.WriteLine("Access Granted");
            tries = 6;
        }

        if (tries == triesLimit)
        {
            Console.WriteLine("You have reached the max number of attempts. Access Denied!");
            guess = password;
        }
    }
   
}


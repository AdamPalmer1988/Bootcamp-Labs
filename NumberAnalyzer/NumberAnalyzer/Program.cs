Console.WriteLine("Welcome to the Number Analyzer");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();

Console.WriteLine("Hello " + name);

string exit = "yes";

while (exit == "yes")
{
    Console.WriteLine(name + "Please enter a number 1-100");
    string stringNumber = Console.ReadLine();

    int number = int.Parse(stringNumber);
    while (number > 0 && number <= 100)
    {
        if ((number < 60) && (number % 2 == 1))
        {
            Console.WriteLine(name + ", your number is odd and less than 60");
            number = 101;
        }
        else if ((number < 25 && number >= 2) && (number % 2 == 0))
        {
            Console.WriteLine(name + ", your number is even and less than 25");
            number = 101;
        }
        else if ((number > 25 && number <= 60) && (number % 2 == 0))
        {
            Console.WriteLine(name + ", even and between 26 and 60 inclusive");
            number = 101;
        }
        else if ((number % 2 == 0) && (number > 60))
        {
            Console.WriteLine(name + ", even and greater than 60");
            number = 101;
        }
        else if ((number % 2 == 1) && (number > 60))
        {
            Console.WriteLine(name + ", odd and greater than 60");
            number = 101;
        }
    }

    if (number < 0)
    {
        Console.WriteLine(name + ", your number is not a positive integer ");
    }

    Console.WriteLine(name + ", would you like to continue? yes or no?");
        exit = Console.ReadLine();

}
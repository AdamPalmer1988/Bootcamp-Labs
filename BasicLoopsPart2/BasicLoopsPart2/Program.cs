Console.WriteLine("Please enter 5 digit password and press enter:");
string guess = "";
string password = "13579";
int tries = 1;
int triesLimit = 5;

do
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
while ((tries <= triesLimit) && (guess != password));
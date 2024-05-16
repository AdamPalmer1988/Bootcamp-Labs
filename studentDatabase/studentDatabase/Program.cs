using System.Security.Cryptography;

string[] names = new string[3];
string[] hometown = new string[3];
string[] favoriteFoods = new string[3]; 

names[0] = "Jarod Goff";
names[1] = "Amon-Ra St. Brown";
names[2] = "Sam Laporta";

hometown[0] = "Grand Haven, Michigan";
hometown[1] = "East Lansing, Michigan";
hometown[2] = "Royal Oak, Michigan";

favoriteFoods[0] = "Chili Chicken Mac n Cheese";
favoriteFoods[1] = "Sun Chips";
favoriteFoods[2] = "Corn";

string keepLooping = "yes";

while (keepLooping == "yes")
{
    Console.WriteLine($"Welcome! Which student would you like to learn more about? Enter a number 1- {names.Length}");

    string studentNumberString = Console.ReadLine();
    int studentNumber = int.Parse(studentNumberString);

    if (studentNumber > names.Length || studentNumber < 1)
    {
        Console.WriteLine($"That number is not between 1-{names.Length}. Would you like to try again? yes or no?");
        keepLooping = Console.ReadLine();
    }

    else
    {
        {
            Console.WriteLine($"Student {studentNumber} is {names[studentNumber - 1]}");
            Console.WriteLine("What would you like to know? hometown or favorite food?");
            string informationString = Console.ReadLine();

            if (informationString == "hometown" || informationString == "favorite food")
            {
                if (informationString == "hometown")
                {
                    Console.WriteLine($"{names[studentNumber - 1]} is from {hometown[studentNumber - 1]}");
                    Console.WriteLine("Would you like to learn about another student? Enter y/n");
                    string anotherStudent = Console.ReadLine();

                    if (anotherStudent == "y")
                    {
                        keepLooping = "yes";
                    }
                    else
                    {
                        Console.WriteLine("Thank you for using the Student Database!");
                        keepLooping = "no";
                    }
                }

                else if (informationString == "favorite food")
                {
                    Console.WriteLine($"{names[studentNumber - 1]}'s favorite food is {favoriteFoods[studentNumber - 1]}");
                    Console.WriteLine("Would you like to learn about another student? Enter y/n");
                    string anotherStudent = Console.ReadLine();

                    if (anotherStudent == "y")
                    {
                        keepLooping = "yes";
                    }
                    else
                    {
                        Console.WriteLine("Thank you for using the Student Database!");
                        keepLooping = "no";
                    }
                }
            }
            else
            {
                Console.WriteLine("That was neither hometown or favorite food.");
            }
        }
    }
}




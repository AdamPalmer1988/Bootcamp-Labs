//First part of Lab
using System;
using System.Threading.Tasks.Dataflow;

Console.WriteLine("Enter a sentence: ");

string userInput = Console.ReadLine();

string[] userInputWithWords = userInput.Split(' ');

for (int i = 0; i < userInputWithWords.Length; i++)
{
    Console.WriteLine($"{userInputWithWords[i]}");
}

//Second part of Lab

List<string> namesList  = new List<string>();

string keepPlaying = "yes";

while (keepPlaying == "yes")
{
    Console.WriteLine("Enter some text: ");
    string someText = Console.ReadLine();

    namesList.Add(someText);
    string joinedText = string.Join(" ", namesList);

    Console.WriteLine($"You have entered: {joinedText} ");
    Console.WriteLine("Would you like to continue? yes or no?");
    keepPlaying = Console.ReadLine();

}
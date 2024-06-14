using Roshambo;

//The application prompts the player to enter a name and select an opponent.

Console.WriteLine("Hello, what is your name?");

string playerName = Console.ReadLine();

Console.WriteLine("Hello " + playerName + "!");


// The application prompts the player to select rock, paper, or scissors. Then, the application displays the player’s
// choice, the opponent’s choice, and the result of the match.

//The application continues until the user doesn’t want to play anymore.

//If the user makes an invalid selection, the application should display an appropriate error message and prompt
//the user again until the user makes a valid selection

HumanPlayer player = new HumanPlayer(playerName);
RockPlayer rock = new RockPlayer();
RandomPlayer random = new RandomPlayer();   

Console.WriteLine("Would you like to play against a Rock or a Random?");

string userSelection = Console.ReadLine();

string keepPlaying = "y";

while (keepPlaying == "y")
{

    if (userSelection == "Rock")
    {
        Console.WriteLine("Please select Rock, Paper, or Scissors");
        string userChoice = Console.ReadLine();

        if (userChoice == "Rock")
        {
            RoshamboChoices rocksChoice = rock.GenerateRoshambo();
            Console.WriteLine("You have chosen " + userChoice);
            Console.WriteLine("Rock has chosen " + rocksChoice);
            Console.WriteLine("It is a Draw. What to Play Again? y or n");

            keepPlaying = Console.ReadLine();
        }
        else if (userChoice == "Paper")
        {
            RoshamboChoices rocksChoice = rock.GenerateRoshambo();
            Console.WriteLine("You have chosen " + userChoice);
            Console.WriteLine("Rock has chosen " + rocksChoice);
            Console.WriteLine("Congratulations you won! Do you wish to play again?  y or n");

            keepPlaying = Console.ReadLine();
        }
        else if (userChoice == "Scissors")
        {
            RoshamboChoices rocksChoice = rock.GenerateRoshambo();
            Console.WriteLine("You have chosen " + userChoice);
            Console.WriteLine("Rock has chosen " + rocksChoice);
            Console.WriteLine("Unfortunately, you lost. Do you wish to play again? y or n");

            keepPlaying = Console.ReadLine();
        }
    }

    else if (userSelection == "Random")
    {
        Console.WriteLine("Please select Rock, Paper, or Scissors");
        string userChoice = Console.ReadLine();
        RoshamboChoices randomChoice = random.GenerateRoshambo();
        string randomChoiceString = randomChoice.ToString();

        if (userChoice == "Rock" && randomChoiceString == "Rock")
        {
            Console.WriteLine("You have chosen " + userChoice);
            Console.WriteLine("Random has chosen " + randomChoice);
            Console.WriteLine("It is a Draw. What to Play Again? y or n");

            keepPlaying = Console.ReadLine();
        }
        else if (userChoice == "Rock" && randomChoiceString == "Scissors")
        {
            Console.WriteLine("You have chosen " + userChoice);
            Console.WriteLine("Random has chosen " + randomChoice);
            Console.WriteLine("Congratulations you won! Do you wish to play again? y or n");

            keepPlaying = Console.ReadLine();
        }
        else if (userChoice == "Rock" && randomChoiceString == "Paper")
        {
            Console.WriteLine("You have chosen " + userChoice);
            Console.WriteLine("Random has chosen " + randomChoice);
            Console.WriteLine("Unfortunately, you lost. Do you wish to play again? y or n");

            keepPlaying = Console.ReadLine();
        }
        else if (userChoice == "Paper" && randomChoiceString == "Rock")
        {
            Console.WriteLine("You have chosen " + userChoice);
            Console.WriteLine("Random has chosen " + randomChoice);
            Console.WriteLine("Congratulations you won! Do you wish to play again? y or n");

            keepPlaying = Console.ReadLine();
        }
        else if (userChoice == "Paper" && randomChoiceString == "Scissors")
        {
            Console.WriteLine("You have chosen " + userChoice);
            Console.WriteLine("Random has chosen " + randomChoice);
            Console.WriteLine("Unfortunately, you lost. Do you wish to play again? y or n");

            keepPlaying = Console.ReadLine();
        }
        else if (userChoice == "Paper" && randomChoiceString == "Paper")
        {
            Console.WriteLine("You have chosen " + userChoice);
            Console.WriteLine("Random has chosen " + randomChoice);
            Console.WriteLine("It is a Draw. What to Play Again? y or n");

            keepPlaying = Console.ReadLine();
        }
        else if (userChoice == "Scissors" && randomChoiceString == "Rock")
        {
            Console.WriteLine("You have chosen " + userChoice);
            Console.WriteLine("Random has chosen " + randomChoice);
            Console.WriteLine("Unfortunately, you lost. Do you wish to play again? y or n");

            keepPlaying = Console.ReadLine();
        }
        else if (userChoice == "Scissors" && randomChoiceString == "Scissors")
        {
            Console.WriteLine("You have chosen " + userChoice);
            Console.WriteLine("Random has chosen " + randomChoice);
            Console.WriteLine("It is a Draw. What to Play Again? y or n");

            keepPlaying = Console.ReadLine();
        }
        else if (userChoice == "Scissors" && randomChoiceString == "Paper")
        {
            Console.WriteLine("You have chosen " + userChoice);
            Console.WriteLine("Random has chosen " + randomChoice);
            Console.WriteLine("Congratulations you won! Do you wish to play again? y or n");

            keepPlaying = Console.ReadLine();
        }

    }

    else
    {
        Console.WriteLine("Please select either Rock or Random");
    }

}

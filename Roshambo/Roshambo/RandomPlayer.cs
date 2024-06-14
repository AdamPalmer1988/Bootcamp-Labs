namespace Roshambo;

public class RandomPlayer : Player
{
    public override RoshamboChoices GenerateRoshambo()
    {
        Random rand = new Random();
        int randNumber = rand.Next(0, 3);
        return (RoshamboChoices)randNumber;
    }
}

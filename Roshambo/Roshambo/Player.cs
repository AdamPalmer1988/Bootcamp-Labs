namespace Roshambo;

//Create an abstract class named Player that stores a name and a Roshambo value. This class
//should include a method named GenerateRoshambo that allows an inheriting class to generate
//and return a Roshambo value.

public abstract class Player
{

    //Attributes
    public RoshamboChoices Value { get; set; }

    //Methods

    public abstract RoshamboChoices GenerateRoshambo();


}

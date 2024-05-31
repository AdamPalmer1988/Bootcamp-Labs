using CircleLabs;

Console.WriteLine("Welcome to the Circle Tester");



bool radiusIsValid = false;
double userRadius = 0;

while (radiusIsValid == false)
{
    try
    {
        Console.WriteLine("Please enter a radius");
        string stringRadius = Console.ReadLine();
        userRadius = double.Parse(stringRadius);
        radiusIsValid = true;
    }

    catch (FormatException fe)
    {
        Console.WriteLine("Please put in a valid radius");
    }
}


Circle radius = new Circle(userRadius);

Console.WriteLine($"Diameter: {radius.CalculateDiameter()}");
Console.WriteLine($"Circumference: {radius.CalculateCircumference()}");
Console.WriteLine($"Area: {radius.CalculateArea()}");

string response = "y"; 

while (response == "y")
{
    Console.WriteLine("Should the circle grow? (y/n)");
    response = Console.ReadLine();

    if (response == "y")
    {
        Console.WriteLine("The circle is magically growing");
        radius.Grow();
        Console.WriteLine($"Diameter: {radius.CalculateDiameter()}");
        Console.WriteLine($"Circumference: {radius.CalculateCircumference()}");
        Console.WriteLine($"Area: {radius.CalculateArea()}");
    }
    else if (response == "n")
    {
        Console.WriteLine($"Goodbye. The circle's final radius is {radius.GetRadius()}");
    }
    else
    {
        Console.WriteLine("Please respond with either y or n");
        response = "y";
    }
}

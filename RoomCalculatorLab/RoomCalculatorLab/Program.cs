//enter values of length and width
Console.WriteLine("Welcome to the Skynet Room Detail Generator!");

Console.WriteLine("Please enter the Length of your Room:");
string stringLength = Console.ReadLine();

int Length = int.Parse(stringLength);

Console.WriteLine("Please enter the Width of your Room:");
string stringWidth = Console.ReadLine();

int Width = int.Parse(stringWidth);

//calculations of Area and Perimeter 

double area = (Length * Width);
double perimeter = ((2 * Length) + (2 * Width));

Console.WriteLine("The Area of your room is " + area);
Console.WriteLine("The Perimeter of your room is " + perimeter);

if (area <= 250)
{
    Console.WriteLine("Your room is smaller room!");
}
 else if (area >= 650 )
{
    Console.WriteLine("Your room is larger in size!");
}
else
{
    Console.WriteLine("Your room is medium-sized room!");
}

Console.WriteLine("Thank you for using the Room Detail Generator!");
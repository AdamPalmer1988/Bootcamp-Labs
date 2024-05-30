using MovieLab;
using System.ComponentModel.Design;

//First Way
//List<Movie> movieList = new List<Movie>();

//instantiation
// Movie movie1 = new Movie("Fast and the Furious 12", "Action Movie");

// movieList.Add(movie1);

List<Movie> movieList = new List<Movie>()
{
    new Movie("Toy Story", "Children"),
    new Movie("Interstellar", "Sci-Fi"),
    new Movie ("Scary Movie", "Comedy"),
    new Movie("Kingpin", "Comedy"),
    new Movie("Titanic", "Drama"),
    new Movie("Die Hard", "Action"),
    new Movie("Frozen", "Children" ),
    new Movie("Ted", "Comedy"),
    new Movie("The Exoricist", "Horror"),
    new Movie("Avatar", "Action")
};

Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine("There are " + movieList.Count + " movies in this list");
Console.WriteLine("What catagory are you interested in?");

string inputCatagory = Console.ReadLine();

void CatagorySearch(List<Movie> movieList, string userCatagory)
{
    for (int i = 0; i < movieList.Count(); i++)
    {
        if (movieList[i].Catagory == userCatagory)
        {
            Console.WriteLine(movieList[i].Title);
        }
    }
}

string keepPlaying = "yes";

while (keepPlaying == "yes")
{
    CatagorySearch(movieList, inputCatagory);

    Console.WriteLine("Would you like to keep going? yes or no?");
    keepPlaying = Console.ReadLine();

    if (keepPlaying == "yes")
    {
        Console.WriteLine("What catagory are you interested in?");
        inputCatagory = Console.ReadLine();
    }
    else
        keepPlaying = "no";
    
}
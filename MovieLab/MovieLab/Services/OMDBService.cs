using MovieLab.Models;

namespace MovieLab.Services;

public class OMDBService : IOMDBService
{
    //make a method that calls the api
    //and returns the C# objects from json

    public async Task<OMDBResponse> SearchMovies(string movieName)
    {
        //create the url as a string with all the info in it
        string url = $"http://www.omdbapi.com/?apikey=16efb775&s={movieName}";

        //call the api and get a response
        using (HttpClient client = new HttpClient())
        {
            try
            {
                //GET JSon Object, turn it into this C# object(OMDBRsponse)
                OMDBResponse response = await client.GetFromJsonAsync<OMDBResponse>(url);
               
                //if the response is good, return the movies
                return response;
            }
            catch (Exception ex) 
            {
                //if the response in not good write a log

                Console.WriteLine(ex.Message);
                return null;
            }
        }


    }
}

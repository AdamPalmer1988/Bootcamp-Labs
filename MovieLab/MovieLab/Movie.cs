using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLab;

public class Movie
{
    //properties

    public string Title { get; set; }
    public string Catagory { get; set; }

    //constructors
    //the class and the constructor will have the same name

    public Movie(string Title, string Catagory)
    {
        this.Title = Title;
        this.Catagory = Catagory;
    }

    //Methods


}



using System.ComponentModel.DataAnnotations;
namespace AdoptionMVC.Models;

public class Animal
{
    public int AnimalId { get; set; } //This is by convention. It will pair up the table name and since it ends in Id, it will know its the PK

    public string Name { get; set; }  

    public string Img {  get; set; }

    public string Description { get; set; }

    public string Breed { get; set; }

    public int Age { get; set; }
}

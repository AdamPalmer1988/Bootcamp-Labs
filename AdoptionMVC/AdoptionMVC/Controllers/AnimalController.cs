using Microsoft.AspNetCore.Mvc;
using AdoptionMVC.Models;
using AdoptionMVC.Models.data;
using System.Diagnostics.Eventing.Reader;

namespace AdoptionMVC.Controllers;

public class AnimalController : Controller
{
    //Dependancy Injection
    private readonly AppDbContext _dbContext;

    public AnimalController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    [HttpPost]
    public IActionResult SearchAnimals(string breedInput)
    {
        //SELECT * FROM Animals WHERE Breed = breedInput
        var animals = _dbContext.Animals.Where(x => x.Breed == breedInput).ToList();
        return View(animals);
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Results(string breed)
    {
        return View();
    }

    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Animal animal)
    {
        if (ModelState.IsValid)
        {
            _dbContext.Add(animal);

            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        return View(animal);
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FastFoodTaco.Data;
using TacoLab.Models.Dto;
using TacoLab.Models;
using System.Linq;

namespace TacoLab.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DrinksController : ControllerBase
{
    //Start Dependancy Injection THIS IS A PATERN
    private readonly FastFoodTacoDbContext _fastFoodTacoDB;

    public DrinksController(FastFoodTacoDbContext fastFoodTacoDbContext)
    {
        _fastFoodTacoDB = fastFoodTacoDbContext;
    }
    //End Dependancy Injection

    [HttpGet]
    public IActionResult GetAllDrinks([FromQuery] string? sortByCost = null)
    {
        IEnumerable<Drink> sortedDrinks;

        if (sortByCost == "Ascending")
        {
           sortedDrinks =  _fastFoodTacoDB.Drinks.OrderBy(x => x.Cost);
        }

        else if (sortByCost == "Descending")
        {
           sortedDrinks = _fastFoodTacoDB.Drinks.OrderByDescending(x => x.Cost);
        }
        else
        {
            sortedDrinks = _fastFoodTacoDB.Drinks;
        }

        return Ok(sortedDrinks.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetDrinkId(int id)
    {
        var drink = _fastFoodTacoDB.Drinks.Find(id);

        if (drink == null)
        {
            return NotFound();
        }

        return Ok(drink);
    }

    [HttpPost]
    public IActionResult CreateRecipe([FromBody] CreateDrinkDto updateDrink)
    {
        Drink newDrink = new Drink();

        newDrink.Name = updateDrink.Name;
        newDrink.Cost = updateDrink.Cost;
        newDrink.Slushie = updateDrink.Slushie;

        _fastFoodTacoDB.Add(newDrink);

        _fastFoodTacoDB.SaveChanges();

        return Ok(newDrink);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateDrink(int id, [FromBody] UpdateDrinkDto updateDrink)
    {
        var drink = _fastFoodTacoDB.Drinks.Find(id);

        if (drink == null)
        {
            return NotFound();
        }

        drink.Name = updateDrink.Name;
        drink.Cost = updateDrink.Cost;
        drink.Slushie = updateDrink.Slushie;

        _fastFoodTacoDB.Add(drink);
        _fastFoodTacoDB.SaveChanges();

        return Ok(drink);
    }
}

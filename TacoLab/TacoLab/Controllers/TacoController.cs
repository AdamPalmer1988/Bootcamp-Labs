using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FastFoodTaco.Data;
using TacoLab.Models.Dto;
using TacoLab.Models;

namespace TacoLab.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TacoController : ControllerBase
{
    //Start Dependancy Injection THIS IS A PATERN
    private readonly FastFoodTacoDbContext _fastFoodTacoDB;

    public TacoController(FastFoodTacoDbContext fastFoodTacoDbContext)
    {
        _fastFoodTacoDB = fastFoodTacoDbContext;
    }
    //End Dependancy Injection

    [HttpGet]
    public IActionResult GetAllTacos([FromQuery] bool? isSoftShell)
    {
        if (isSoftShell != null)
        {
            return Ok(_fastFoodTacoDB.Tacos.Where(x => x.SoftShell == isSoftShell).ToList());
        }

        return Ok(_fastFoodTacoDB.Tacos.ToList());
    }

    //api/Recipe/2
    [HttpGet("{id}")]
    public IActionResult GetTacoId(int id)
    {
        var recipe = _fastFoodTacoDB.Tacos.Find(id);

        if (recipe == null)
        {
            return NotFound();
        }

        return Ok(recipe);
    }

    [HttpPost]
    public IActionResult CreateRecipe([FromBody] CreateTacoDto updateTaco)
    {
        Taco newTaco = new Taco();

        newTaco.Name = updateTaco.Name;
        newTaco.Cost = updateTaco.Cost;
        newTaco.SoftShell = updateTaco.SoftShell;
        newTaco.Chips = updateTaco.Chips;

        _fastFoodTacoDB.Add(newTaco);

        _fastFoodTacoDB.SaveChanges();

        return Ok(newTaco);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteTaco(int id)
    {
        var taco = _fastFoodTacoDB.Tacos.Find(id);

        if (taco == null)
        {
            return NotFound();
        }

        _fastFoodTacoDB.Tacos.Remove(taco);
        _fastFoodTacoDB.SaveChanges();

        return NoContent();
    }
}

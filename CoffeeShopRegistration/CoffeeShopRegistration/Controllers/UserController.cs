using Microsoft.AspNetCore.Mvc;
using CoffeeShopRegistration.Models;
using CoffeeShopRegistration.Models.Data;

namespace CoffeeShopRegistration.Controllers;

public class UserController : Controller
{
    //Dependency Injection
    private AppDbContext _dbContext;

    public UserController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    //End of Dependancy Injection 

    public IActionResult Register()
    {
        return View();
    }

    //The user on line 18 represents the data
    //the person typed into the form

    [HttpPost]

    public IActionResult RegisterUser(User user)
    {
        _dbContext.Add(user);

        _dbContext.SaveChanges();

        return RedirectToAction("Index", "Home");
    }

}

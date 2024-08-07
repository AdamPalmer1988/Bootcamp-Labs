﻿using System.ComponentModel.DataAnnotations;

namespace CoffeeShopRegistration.Models;

public class User
{
    public int UserId { get; set; }

    [Required(ErrorMessage = "First name is required")] //This is called annotation... For Validation of information
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Last name is required")]
    public string LastName { get; set; }
    [EmailAddress]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
    public string Password { get; set; }

}

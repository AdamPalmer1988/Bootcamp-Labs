using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RestaurantFaves.Data;
using RestaurantFaves.Models;

namespace RestaurantFaves.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    //Start Dependancy Injection THIS IS A PATERN
    private readonly OrderDbContext _orderDB;

    public OrderController(OrderDbContext orderDbContext)
    {
        _orderDB = orderDbContext;
    }

    [HttpGet]
    public IActionResult getAllOrders([FromQuery] bool? orderAgain, [FromQuery] string? restaurant)
    {
        var orders = _orderDB.Orders.AsQueryable();

        if (orderAgain.HasValue)
        {
            orders = orders.Where(x => x.OrderAgain == orderAgain.Value);
        }

        if (!restaurant.IsNullOrEmpty())
        {
            orders = orders.Where(x => x.Restaurant == restaurant);
        }

        return Ok(orders.ToList());
    }

    //api/Recipe/2
    [HttpGet("{id}")]
    public IActionResult getOrderId(int id)
    {
        var order = _orderDB.Orders.Find(id);

        if (order == null)
        {
            return NotFound();
        }
        return Ok(order);
    }


    [HttpPost]
    public IActionResult createOrder([FromBody] Order updateOrder)
    {
        Order newOrder = new Order();

        newOrder.Description = updateOrder.Description;
        newOrder.Restaurant = updateOrder.Restaurant;
        newOrder.Rating = updateOrder.Rating;
        newOrder.OrderAgain = updateOrder.OrderAgain;

        _orderDB.Add(newOrder);

        _orderDB.SaveChanges();

        return Ok(newOrder);
    }

    [HttpPut("{id}")]
    public IActionResult updateOrder(int id, [FromBody] Order updateOrder)
    {
        var order = _orderDB.Orders.Find(id);

        if (order == null)
        {
            return NotFound();
        }

        order.Description = updateOrder.Description;
        order.Restaurant = updateOrder.Restaurant;
        order.Rating = updateOrder.Rating;
        order.OrderAgain = updateOrder.OrderAgain;

        _orderDB.Add(order);
        _orderDB.SaveChanges();

        return Ok(order);

    }

    [HttpDelete("{id}")]
    public IActionResult deleteOrder(int id)
    {
        var order = _orderDB.Orders.Find(id);

        if (order == null)
        {
            return NotFound();
        }

        _orderDB.Orders.Remove(order);
        _orderDB.SaveChanges();

        return NoContent();
    }
}

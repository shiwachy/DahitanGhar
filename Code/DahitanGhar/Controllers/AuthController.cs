using DahitanGhar.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DahitanGhar.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : Controller
{
    private readonly IDgDbContext dgDbContext;
    public AuthController(IDgDbContext _dgDbContext)
    {
        dgDbContext = _dgDbContext;
    }

    [HttpGet("GetUsers")]
    public IActionResult GetUsers()
    {
        var users = dgDbContext.Users.ToList();
        return Ok();
    }


    [HttpPost("SendUsers")]
    public IActionResult SendUsers()
    {
        var users = dgDbContext.Users.ToList();
        return Ok();
    }
}

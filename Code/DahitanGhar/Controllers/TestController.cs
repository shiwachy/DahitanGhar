using DahitanGhar.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace DahitanGhar.Web.Controllers;

[ApiController]
[Route("api/Controller")]
public class TestController : ControllerBase
{
    [HttpGet("xyz")]
   public ActionResult<Class1> GetDataTest()
    {
        Class1 newClass = new Class1();
        return newClass;
    }

    [HttpGet("abc")]
    public ActionResult<Class2> GetDataTest1()
    {
        Class2 newClass = new Class2();
        return newClass;
    }

}

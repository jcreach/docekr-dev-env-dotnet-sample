using Microsoft.AspNetCore.Mvc;

namespace MySuperAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorldController : ControllerBase
{
    [HttpGet(Name = "HelloWorld")]
    public string Get()
    {
        return "Hello from docker dotnet API in a docker dev env";
    }
}

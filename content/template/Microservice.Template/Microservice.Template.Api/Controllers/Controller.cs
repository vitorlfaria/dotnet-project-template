using Microsoft.AspNetCore.Mvc;

namespace Microservice.Template.Api;

[ApiController]
[Route("[controller]")]
[Produces("application/json")]
public class Controller : ControllerBase
{
    [HttpGet("api/[controller]")]
    public IActionResult Get()
    {
        return Ok("Hello World");
    }
}

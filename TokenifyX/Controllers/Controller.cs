using Microsoft.AspNetCore.Mvc;

namespace TokenifyX.Controllers;

[ApiController]
[Route("[controller]")]
public class Controller : ControllerBase
{
    [HttpGet("/")]
    public async Task<ActionResult<string>> Webhook()
    {
        return Ok("papiez.jpg");
    }
    
}
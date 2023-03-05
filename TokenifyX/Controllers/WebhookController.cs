using Microsoft.AspNetCore.Mvc;

namespace TokenifyX.Controllers;

[ApiController]
[Route("")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet("/webhook")]
    public async Task<ActionResult<string>> Webhook()
    {
        var webResponse = Request.Body;
        Console.WriteLine(webResponse);
        return Ok(webResponse);
    }
    
    [HttpPost("/webhook")]
    public async Task<ActionResult<string>> Webhook2ND()
    {
        var webResponse = Request.Body;
        Console.WriteLine(webResponse);
        return Ok(webResponse);
    }
}
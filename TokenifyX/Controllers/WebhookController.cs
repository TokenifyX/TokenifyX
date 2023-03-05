using Microsoft.AspNetCore.Mvc;

namespace TokenifyX.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpPost("/webhook")]
    public async Task<ActionResult<string>> Webhook()
    {
        var webResponse = Request.Body;
        return Ok(webResponse);
    }
    
    [HttpGet("/wbhook")]
    public async Task<ActionResult<string>> Webhook2d()
    {
        var webResponse = Request.Body;
        return Ok(webResponse);
    }
}
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
        return Ok(webResponse);
    }
}
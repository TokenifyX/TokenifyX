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
}
using Microsoft.AspNetCore.Mvc;

namespace ApiServer.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    [Route("")]
    [HttpGet]
    public async Task<IActionResult> HelloWorld()
    {
        return Ok("Hello World!"); 
    }
}
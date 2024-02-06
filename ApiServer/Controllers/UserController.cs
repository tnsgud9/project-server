using Microsoft.AspNetCore.Mvc;
using Shared;

namespace ApiServer.Controllers;

[ApiController]
[Route("api/")]
public class UserController : ControllerBase
{
    [Route(ApiUrl.Login)]
    [HttpGet]
    public async Task<IActionResult> Login()
    {
        return Ok("login");
    }

    [Route(ApiUrl.Signup)]
    [HttpGet]
    public async Task<IActionResult> SignUp()
    {
        return Ok("signup");
    }
}   
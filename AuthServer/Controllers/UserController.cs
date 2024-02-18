using Microsoft.AspNetCore.Mvc;
using Shared;

namespace AuthServer.Controllers;

[ApiController]
[Route("auth")]
public class UserController : ControllerBase
{
    [Route(ApiUrl.UserLogin)]
    [HttpPost]
    public async Task<IActionResult> UserLogin()
    {
        return Ok("login");
    }

    [Route(ApiUrl.UserSignup)]
    [HttpPost]
    public async Task<IActionResult> UserSignUp()
    {
        return Ok("signup");
    }
    
    [Route(ApiUrl.UserEdit)]
    [HttpPost]
    public async Task<IActionResult> UserEdit()
    {
        return Ok("Edit");
    }

    [Route(ApiUrl.UserDelete)] 
    [HttpPost] 
    public async Task<IActionResult> UserDelete()
    {
        return Ok("Delete");
    }
}   
using Microsoft.AspNetCore.Mvc;
using Shared;

namespace AuthServer.Controllers;

[ApiController]
[Route("auth")]
public class AccountController : ControllerBase
{
    [Route(ApiUri.UserLogin)]
    [HttpPost]
    public async Task<IActionResult> UserLogin()
    {
        return Ok("login");
    }

    [Route(ApiUri.UserSignup)]
    [HttpPost]
    public async Task<IActionResult> UserSignUp()
    {
        return Ok("signup");
    }
    
    [Route(ApiUri.UserEdit)]
    [HttpPost]
    public async Task<IActionResult> UserEdit()
    {
        return Ok("Edit");
    }

    [Route(ApiUri.UserDelete)] 
    [HttpPost] 
    public async Task<IActionResult> UserDelete()
    {
        return Ok("Delete");
    }
}   
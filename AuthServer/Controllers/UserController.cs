using Microsoft.AspNetCore.Mvc;
using Shared;

namespace AuthServer.Controllers;
/// <summary>
/// 사용자 계정과 관련된 작업을 처리하며 로그인, 회원가입, 비밀번호 변경 및 보안 기능을 수행한다.
/// </summary>
[ApiController]
[Route("auth")]
public class UserController : ControllerBase {
    [Route(ApiUri.UserLogin)]
    [HttpPost]
    public async Task<IActionResult> UserLogin() {
        return Ok("login");
    }

    [Route(ApiUri.UserSignup)]
    [HttpPost]
    public async Task<IActionResult> UserSignUp() {
        return Ok("signup");
    }

    [Route(ApiUri.UserEdit)]
    [HttpPost]
    public async Task<IActionResult> UserEdit() {
        return Ok("Edit");
    }

    [Route(ApiUri.UserDelete)]
    [HttpPost]
    public async Task<IActionResult> UserDelete() {
        return Ok("Delete");
    }
}
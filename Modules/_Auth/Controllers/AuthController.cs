using Microsoft.AspNetCore.Mvc;
using Todolist.Modules._Auth.Models;
using Todolist.Modules._Auth.Services;
using System;
namespace Todolist.Modules._Auth.Controllers
{
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private IUserService _userService;
        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public IActionResult Authenticate([FromBody] AuthenticateRequest model)
        {
            // Console.WriteLine(model.USERNAME);
            // return BadRequest(new { message = "Không hợp lệ : "+model.USERNAME });
            var response = _userService.Authenticate(model);
            if (response == null){
                return BadRequest(new { message = "Không hợp lệ : "+model.username });
            }
            return Ok(response);
        }
    }
}

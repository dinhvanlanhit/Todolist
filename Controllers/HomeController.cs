using Microsoft.AspNetCore.Mvc;
using Todolist.Models;
using Todolist.Services;
namespace Todolist.Controllers
{
    [Route("api/home")]
    public class HomeController : ControllerBase
    {
        // private IUserService _userService;
        // public HomeController(IUserService userService)
        // {
        //     _userService = userService;
        // }
        public IActionResult getHome()
        {
             return Ok(new {name = "Fabio", age = 42, gender = "M"});
        }
        // [Authorize]
        // [HttpGet("GetAll")]
        // public IActionResult GetAll()
        // {
        //     var users = _userService.GetAll();
        //     return Ok(users);
        // }

    }
}
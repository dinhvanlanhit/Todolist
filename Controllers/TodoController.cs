using Microsoft.AspNetCore.Mvc;
using Todolist.Models;
using Todolist.Services;
using Todolist.Helpers;
namespace Todolist.Controllers
{

    [Route("api/todo")]
    public class TodoController : ControllerBase
    {
        private DataContext db = new DataContext();
        // private IUserService _userService;
        // public HomeController(IUserService userService)
        // {
        //     _userService = userService;
        // }
        [Authorize]
        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            var todos = db.Todos;
            // return Ok(new{data=todos});
            return Ok(new {todos = todos});
        }
    }
}
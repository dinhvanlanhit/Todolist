using Microsoft.AspNetCore.Mvc;
using Todolist.Helpers;
using Todolist.Modules._Todo.Models;
using Todolist.Modules._Todo.Services;
using System;
namespace Todolist.Modules._Todo.Controllers
{

    [Route("api/todo")]
    public class TodoController : ControllerBase
    {
        private ITodoService _todoService;
        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }
        [Authorize]
        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            var todos = _todoService.GetAll();
            // return Ok(new{data=todos});
            return Ok(new {todos = todos});
        }
        // [Authorize]
        // [HttpPost("add")]
        // public IActionResult add([FromBody] Todo model)
        // {
        //     var todos = _todoService.add(Todo);
        //     // return Ok(new{data=todos});
        //     return Ok(new {status = true});
        // }
        [Authorize]
        [HttpPost("byid")]
        public IActionResult byid([FromBody] Todo model)
        {
            var todo = _todoService.byid(model);
            // return Ok(new{data=todos});
            return Ok(new {data = todo});
        }
    }
}
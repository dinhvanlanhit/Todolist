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
            try
            {
                var todos = _todoService.GetAll();
                return Ok(new {todos = todos});
            }
            catch (Exception ex)
            {
                return Ok(new {Message  = ex.Message});
            }
           
        }
        [Authorize]
        [HttpPost("add")]
        public IActionResult add([FromBody] Todo model)
        {
            try
            {
                var todos = _todoService.add(model);
                return Ok(todos);
            }
            catch (Exception ex)
            {
                return Ok(new {Message  = ex.Message});
            }
        }
        [Authorize]
        [HttpPost("edit")]
        public IActionResult edit([FromBody] Todo model)
        {
            try
            {
                var todos = _todoService.edit(model);
                return Ok(todos);
            }
            catch (Exception ex)
            {
                return Ok(new {Message  = ex.Message});
            }
        }
        [Authorize]
        [HttpPost("byid")]
        public IActionResult byid([FromBody] Todo model)
        {
            try
            {
                var todo = _todoService.byid(model);
                return Ok(new {data = todo});
            }
            catch (Exception ex)
            {
                return Ok(new {Message  = ex.Message});
            }
        }
        [Authorize]
        [HttpPost("delete")]
        public IActionResult delete([FromBody] Todo model)
        {
            try
            {
                var todos = _todoService.delete(model);
                return Ok(todos);
            }
            catch (Exception ex)
            {
                return Ok(new {Message  = ex.Message});
            }
        }
    }
}
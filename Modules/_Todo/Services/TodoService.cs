using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Todolist.Helpers;
using Todolist.Modules._Todo.Models;

namespace Todolist.Modules._Todo.Services
{
    public interface ITodoService
    {
        IEnumerable<Todo> GetAll();
        Todo byid(Todo todo);
        // Todo add(Todo todo);
        // Todo edit(Todo todo);
        // Todo delete(Todo todo);
    }

    public class TodoService : ITodoService
    {
        private DataContext db = new DataContext();


        public IEnumerable<Todo> GetAll()
        {
            return db.Todos;
        }

        public Todo byid(Todo todo)
        {
            return db.Todos.FirstOrDefault(x => x.ID == todo.ID);
        }
        // public Todo add(Todo todo)
        // {
        //     return new {data=1};
        // }
        // public Todo edit(Todo todo)
        // {
        //     return new  {data=1};
        // }
        // public Todo delete(Todo todo)
        // {
        //     return db.Todo.Where(x => x.ID == todo.ID).DeleteAsync();
        // }
    }
}
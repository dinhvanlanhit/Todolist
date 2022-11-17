using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Linq;
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
        // IEnumerable add(Todo todo);
        Response edit(Todo todo);
        Response add(Todo todo);
        Response delete(Todo todo);
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
            return db.Todos.FirstOrDefault(x => x.id == todo.id);
        }
        public Response add(Todo todo)
        {
            var item = db.Todos.FirstOrDefault(x => x.name == todo.name);
            if (item != null)
            {
                return new Response("Tên đã được sử dụng",false);
            }else{
                todo.date_create = DateTime.Now;
                db.Todos.Add(todo);
                var check = db.SaveChanges() > -1;
                if (check)
                {
                    return new Response("Thêm thành công",true);
                }else{
                    return new Response("Thêm không thành công",false);
                }
            }
        }
        public Response edit(Todo todo)
        {
            var item = db.Todos.FirstOrDefault(x => x.id == todo.id);
            if (item == null)
            {
                return new Response("Không tìm thấy dữ liệu",false);
            }else{
                item.date_update = DateTime.Now;
                item.name = todo.name;
                item.is_active = todo.is_active;
                db.Todos.Update(item);
                var check = db.SaveChanges() > -1;
                if (check)
                {
                    return new Response("Cập nhật thành công",true);

                }else{
                    return new Response("Cập nhật không thành công",false);
                }
            }
        }
        public Response delete(Todo todo)
        {
            var item = db.Todos.FirstOrDefault(x => x.id == todo.id);
            if (item == null)
            {
                return new Response("Không tìm thấy dữ liệu",false);
            }else{
                db.Todos.Remove(item);
                var check = db.SaveChanges() > -1;
                if (check)
                {
                    return new Response("Xóa thành công",true);

                }else{
                    return new Response("Xóa thành không thành công",false);
                }
            }
        }
    }
}
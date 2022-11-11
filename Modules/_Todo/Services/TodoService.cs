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
            return db.Todos.FirstOrDefault(x => x.ID == todo.ID);
        }
        public Response add(Todo todo)
        {
            var item = db.Todos.FirstOrDefault(x => x.NAME == todo.NAME);
            if (item != null)
            {
                return new Response("Tên đã được sử dụng",false);
            }else{
                todo.DATE_CREATE = DateTime.Now;
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
            var item = db.Todos.FirstOrDefault(x => x.ID == todo.ID);
            if (item == null)
            {
                return new Response("Không tìm thấy dữ liệu",false);
            }else{
                item.DATE_UPDATE = DateTime.Now;
                item.NAME = todo.NAME;
                item.IS_ACTIVE = todo.IS_ACTIVE;
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
            var item = db.Todos.FirstOrDefault(x => x.ID == todo.ID);
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
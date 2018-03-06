using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class TodoController : ApiController
    {
        Todo[] todos = new Todo[]
        {
            new Todo { Id = 1, Name = "Eat food", Description = "Need to eat", IsComplete = false, DueDate = new DateTime(2018,3,6,10,55,0)},
            new Todo { Id = 2, Name = "Exercise", Description = "", IsComplete = false, DueDate = new DateTime(2018,3,6,11,20,0)},
            new Todo { Id = 3, Name = "Sleep", Description = "", IsComplete = false, DueDate = new DateTime(2018,3,6,13,30,0)}
        };

        public IEnumerable<Todo> GetAllTodos()
        {
            return todos;
        }

        public IHttpActionResult GetTodo(int id)
        {
            Todo todo = todos.FirstOrDefault(t => t.Id == id);
            if(todo == null)
            {
                return NotFound();
            }
            return Ok(todo);
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoModels;

namespace Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TodosController
    {
        List<Todo> allTodos = new List<Todo>();
        [HttpGet("all")]
        public List<Todo> ListAllTodos()
        {
            // How to debug in C#
            return allTodos;
        }
        [HttpPost("add")]
        public List<Todo> createTodo([FromBody] Todo myTodo)
        {
            Todo newTodo = new Todo {Name = myTodo.Name, Description = myTodo.Description};
            allTodos.Add(newTodo);
            return allTodos;
        }
    }
}
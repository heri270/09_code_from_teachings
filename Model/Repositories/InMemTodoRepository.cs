using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWebApi.Model.Entities;
using TodoWebApi.Model.Repositories;

namespace TodoWebApi.Model.Repositories
{
    public class InMemTodoRepository : ITodoRepository
    {
        List<TodoItem> todoList;
        public InMemTodoRepository()
        {
            todoList = new List<TodoItem>();
            todoList.Add(new TodoItem{TodoItemID = 1, Task = "First task 1", IsComplete = false});
            todoList.Add(new TodoItem{TodoItemID = 2, Task = "First task 2", IsComplete = false});
            todoList.Add(new TodoItem{TodoItemID = 3, Task = "First task 3", IsComplete = false});
        }

        public void Create(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TodoItem Get(int id)
        {
            return todoList.Find(item => item.TodoItemID == id);
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return todoList;
        }

        public void Update(TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}

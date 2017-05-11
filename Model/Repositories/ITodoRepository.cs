using System;
using System.Collections.Generic;
using TodoWebApi.Model.Entities;

namespace TodoWebApi.Model.Repositories
{
    public interface ITodoRepository{
        // CRUD Functionality

        void Create(TodoItem item);
        TodoItem Get(int id);
        IEnumerable<TodoItem> GetAll();
        void Update(TodoItem item);
        void Delete(int id);
    }
}
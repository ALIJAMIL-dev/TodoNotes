using System.Collections.Generic;
using TodoNotes.Entities.Concrete;

namespace TodoNotes.Business.Abstract
{
    public interface ITodoItemService
    {
        List<TodoItem> GetAll();
        TodoItem GetById(int id);
        void Add(TodoItem todo);
        void Update(TodoItem todo);
        void Delete(TodoItem todo);
    }
}

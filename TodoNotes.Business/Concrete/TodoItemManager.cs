using System.Collections.Generic;
using TodoNotes.Business.Abstract;
using TodoNotes.Business.Utilities;
using TodoNotes.Business.ValidationRules.FluentValidation;
using TodoNotes.DataAccess.Abstract;
using TodoNotes.DataAccess.Concrete.EntityFramework;
using TodoNotes.Entities.Concrete;
using FluentValidation;


namespace TodoNotes.Business.Concrete
{
    public class TodoItemManager : ITodoItemService
    {
        private readonly ITodoItemDal _todoItemDal;

        public TodoItemManager(ITodoItemDal todoItemDal)
        {
            _todoItemDal = todoItemDal;
        }

        public List<TodoItem> GetAll() => _todoItemDal.GetAll();

        public TodoItem GetById(int id)
            => _todoItemDal.Get(t => t.Id == id);

        public void Add(TodoItem todo)
            {
                ValidationTool.Validate(new TodoItemValidator(), todo);
                _todoItemDal.Add(todo);
            }
        public void Update(TodoItem todo)
        {
            ValidationTool.Validate(new TodoItemValidator(), todo);
            _todoItemDal.Update(todo);
        }
        public void Delete(TodoItem todo)
        {
            _todoItemDal.Delete(todo);
        }
    }
}

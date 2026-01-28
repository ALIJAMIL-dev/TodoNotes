using System;
using System.Collections.Generic;
using TodoNotes.Entities.Concrete;

namespace TodoNotes.DataAccess.Abstract
{
    public interface ITodoItemDal : IEntityRepository<TodoItem>
    {
    }
}

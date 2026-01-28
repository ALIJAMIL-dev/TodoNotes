using TodoNotes.DataAccess.Abstract;
using TodoNotes.Entities.Concrete;

namespace TodoNotes.DataAccess.Concrete.EntityFramework
{
    public class EfNoteDal
        : EfEntityRepositoryBase<Note, TodoContext>,
          INoteDal
    {
    }
}

using TodoNotes.Entities.Concrete;

namespace TodoNotes.DataAccess.Abstract
{
    public interface INoteDal : IEntityRepository<Note>
    {
    }
}

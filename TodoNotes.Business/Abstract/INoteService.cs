using System.Collections.Generic;
using TodoNotes.Entities.Concrete;

namespace TodoNotes.Business.Abstract
{
    public interface INoteService
    {
        List<Note> GetAll();
        Note GetById(int id);
        void Add(Note note);
        void Update(Note note);
        void Delete(Note note);
    }
}

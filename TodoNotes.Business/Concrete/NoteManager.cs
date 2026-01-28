using System;
using System.Collections.Generic;
using TodoNotes.Business.Abstract;
using TodoNotes.DataAccess.Abstract;
using TodoNotes.Entities.Concrete;

namespace TodoNotes.Business.Concrete
{
    public class NoteManager : INoteService
    {
        private readonly INoteDal _noteDal;

        public NoteManager(INoteDal noteDal)
        {
            _noteDal = noteDal;
        }

        public List<Note> GetAll() => _noteDal.GetAll();

        public Note GetById(int id)
            => _noteDal.Get(n => n.Id == id);

        public void Add(Note note)
        {
            _noteDal.Add(note);
        }

        public void Update(Note note)
        {
            note.UpdatedAt = DateTime.Now;
            _noteDal.Update(note);
        }

        public void Delete(Note note)
        {
            _noteDal.Delete(note);
        }
    }
}

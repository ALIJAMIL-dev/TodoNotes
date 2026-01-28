using System;
using TodoNotes.Entities.Abstract;

namespace TodoNotes.Entities.Concrete
{
    public class Note : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
